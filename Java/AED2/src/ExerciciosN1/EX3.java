/**
 * 
 */
package ExerciciosN1;

/**
 * @author gabri
 *
 */
import java.util.List;
import java.util.ArrayList;

public class EX3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//Crie um programa que imprima na tela um triângulo de “*”:
		List<List> ast;
		List<String> txt;
		txt = new ArrayList<String>();
		ast = new ArrayList<List>();
		
		String linha ="";
		String esp = " ";
		String x = "*";
		for(int i=12;i>0;i--) {
			System.out.println(txt);
			for(int a=0;a<(i/2);a++) {
				linha = linha + esp;
			}
			txt.add(linha);
			txt.add(x);
			txt.add(linha);
			System.out.println(txt);
			ast.add(txt);
			txt.clear();	
		}
		System.out.println(ast);
	}  

}
