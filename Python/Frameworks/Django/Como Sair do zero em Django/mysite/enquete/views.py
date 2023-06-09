from django.shortcuts import get_object_or_404, render
from django.http import HttpResponse, HttpResponseRedirect
from django.urls import reverse

from .models import Question, Choice

# Create your views here.

def index(request):
    latest_quetion_list = Question.objects.order_by('-pub_date')[:5]
    context = {'latest_question_list': latest_quetion_list}
    return render(request, 'enquete/index.html', context)

def detail(request, question_id):
    return HttpResponse('Essa é a pergunta de número %s' %question_id)

def results(request, question_id):
    question = Question(pk=question_id)
    return render(request, 'enquete/result.html', {'question': question})

def vote(request, question_id):
    question = get_object_or_404(Question, pk=question_id)
    try:
        selected_choice = question.choice_set.get(pk=request.POST['choice'])
    except KeyError:
        return render(request, 'enquete/vote.html', {
            'question': question,
            'error_message': 'You didn´t select a choice.',
        })
    else:
        selected_choice.votes += 1
        selected_choice.save()
        return HttpResponseRedirect(reverse('enquete:results', args=(question_id,)))