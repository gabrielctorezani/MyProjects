import os

class Dinheiro:
    def __init__(self,LucroAnterior,Lucro,Investido,Montante,MontanteAnterior):
       self.list = []
       self.la = LucroAnterior
       self.lu = Lucro   
       self.Invest = Investido
       self.r = 0
       self.m = Montante
       self.a = MontanteAnterior
       pass
    def ad(self,list,APLICADO,AMON,RETIRA,MONTANTE,LUCROAA,LUCRO,intOrstr):
        if(intOrstr == int):
            list.append(APLICADO)
            list.append(AMON)
            list.append(RETIRA)
            list.append(MONTANTE)
            list.append(LUCROAA)
            list.append(LUCRO)
            return list
        elif(intOrstr == str):
            list.append(self.Converte(APLICADO))
            list.append(self.Converte(AMON))
            list.append(self.Converte(RETIRA))
            list.append(self.Converte(MONTANTE))
            list.append(self.Converte(LUCROAA))
            list.append(self.Converte(LUCRO))
            return list
    def Func(self,cont,tx,intOrstr):
       for i in range(cont):
          if(i<3 or i>=3):
             self.la = self.lu
             self.ma = ((self.Invest+self.r)*tx)
             self.m = self.m + self.ma 
             self.a = self.m
             self.r = self.m/2
             self.m = self.m-self.r
             self.lu = self.lu + self.m
             self.ad(self.list,self.ma,self.a,self.r,self.m,self.la,self.lu,intOrstr)
       return list    
    
    def imprimi(self,a):
        c = 0
        for i in range(a):   
           print(i,'::')
           print('Aplicado',round(self.list[c]))
           c = c+1
           print('Montante anterior',round(self.list[c]))
           c = c+1
           print('Retirado montante',round(self.list[c]))
           c = c+1
           print('Montante',round(self.list[c]))
           c = c+1
           print('Lucro Anterior',round(self.list[c]))
           c = c+1
           print('Lucro',round(self.list[c]))
           print('  ')
           c = c+1
    def EscreveTxt(self,nome,a):
        c = 0
        with open(f'{nome}.txt', 'w') as arquivo:    
            for i in range(a):
              arquivo.write(f'{i+1}::')
              arquivo.write(f'Aplicado:: {self.list[c]}\n')
              c = c+1
              arquivo.write(f'Montante anterior:: {self.list[c]}\n')
              c = c+1
              arquivo.write(f'Retirado montante:: {self.list[c]}\n')
              c = c+1
              arquivo.write(f'Montante:: {self.list[c]}\n')
              c = c+1
              arquivo.write(f'Lucro Anterior:: {self.list[c]}\n')
              c = c+1
              arquivo.write(f'Lucro:: {self.list[c]}\n')
              arquivo.write('  \n')
              c = c+1    
    def Converte(self,valor):
        valor = round(valor,1)
        a = str(valor)
        v = ''
        s = 0
        m = 0
        p = 0
        ver = 0
        final = ''
        print(valor)
        if(len(a)>=3 or len(a)<6 and valor != 0):
            p = valor%1000
            s = valor/10**3
            m = valor-p
            v = v+f'{int((p))},00'
            ver = int(s)-(round(s,0)-s)
            final = ''
            if(len(a)>=6 or len(a)<9 and m != 0 and ver > 0):
                p = (int(s)-int(m))%1000
                s = valor/10**6
                m = m-(p*1000)
                v = f'{int(p)}.'+v
                ver = round(s,0)
                final = ' MIL'
                if(len(a)>=9 or len(a)<12 and m != 0 and ver > 0):
                    p = (int(s)-int(m))%1000
                    s = valor/10**9
                    m = m-(p*1000)
                    v = f'{int(p)}.'+v
                    ver = round(s,0)
                    final = ' MILHOES'
                    if(len(a)>=12 or len(a)<15 and m != 0 and ver > 0):
                        p = (int(s)-int(m))%1000
                        s = valor/10**12
                        m = m-(p*1000)
                        v = f'{int(p)}.'+v
                        ver = round(s,0)
                        final = ' BILHOES'
                        if(len(a)>=15 or len(a)<18 and m != 0 and ver > 0):
                            p = (int(s)-int(m))%1000
                            s = valor/10**12
                            m = m-(p*1000)
                            v = f'{int(p)}.'+v
                            ver = round(s,0)
                            final = ' TRILHOES'
        if(s>0):
            v = 'R$'+v+final
        else:
            v = '--'
        return v

    def Leitura(self,nome,cont):
        with open(f'{nome}.txt', 'r') as arquivo:    
            for i in range(cont):
                if(i==cont):
                    return
    
    def C(self,cont):
        return int(self.list[(cont*6)-1])


a = 5000*1.99
b = 500
c = 3000*2.99
d = 800
D = Dinheiro(0,0,a,0,0)
D1 = Dinheiro(0,0,b,0,0)
D2 = Dinheiro(0,0,c,0,0)
D3 = Dinheiro(0,0,d,0,0)

D.Func(12,1.6,str)
D1.Func(12,1.5,str)
D2.Func(12,2,str)
D3.Func(12,2.1,str)
D.EscreveTxt('a',12)
D1.EscreveTxt('b',12)
D2.EscreveTxt('c',12)
D3.EscreveTxt('d',12)

'''''

D.Func(12,1.6,int)
D1.Func(9,1.5,int)
D2.Func(6,2,int)
D3.Func(3,2.1,int)
c = D.C(12)+D1.C(9)+D2.C(6)+D3.C(3)
print(c)
#self,LucroAnterior,Lucro,Investido,Montante,MontanteAnterior)
#cont,tx): 6735.0555 
'''''