/**
 * 
 */
package ExerciciosN1;

/**
 * @author gabri
 *
 */
public class EX2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// Crie um programa que exiba os números pares entre 1 e 100.
		int par;
		for(int i=0;i<=100;i++) {
			if(i%2 == 0) {
				System.out.println(i+" é par!");
			}
		}
		System.out.println("Fim!");
	}

}
