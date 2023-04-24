/**
 * 
 */
package ExerciciosN1;

/**
 * @author gabri
 *
 */
import java.util.Scanner;
public class EX1 {
	
	public static void main(String[] args) {
		//Crie um programa que exiba o seu nome na tela 100 vezes.
		String nome;
		Scanner input = new Scanner(System.in);
		System.out.println("Insira o nome:");
		nome = input.nextLine();
		for(int i=1;i<=100;i++) {
			System.out.println(i+" "+nome);
		}
		System.out.println("Fim!!");

	}

}
