/**
 * 
 */
package src;

/**
 * @author gabri
 *
 */
import java.io.FileWriter;
import java.io.PrintWriter;
import java.io.IOException;
import java.util.Scanner;
import java.io.BufferedWriter;

public class Arquivos {

	/**
	 * @param args
	 */
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Scanner in = new Scanner(System.in);
		String path = "C:\\Users\\gabri\\OneDrive - ynzws\\MyProjets\\Java\\AED2\\Arquivos\\Exercicios2.txt";
		
		try {
			FileWriter verifica = new FileWriter(path,true);
			BufferedWriter conexao = new BufferedWriter(verifica);
			conexao.newLine();
			for(int i =0; i<100;i++) {
				conexao.write(i+" :ASD\n");
			}
			conexao.close();
		}
		catch(Exception e){
			e.printStackTrace();
		}/*
		FileWriter arq = new FileWriter(path);
		PrintWriter grava = new PrintWriter(arq);
		for(int i = 0; i<100; i++) {
			grava.printf(i+" :Teste\n");
		}
		path.close();*/
	
    }
}
	
	
