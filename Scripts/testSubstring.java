import com.sun.org.apache.bcel.internal.classfile.LineNumber;

import java.io.*;
import java.util.List;
import java.util.Scanner;


public class testSubstring {
    public static void main(String args[]) throws FileNotFoundException {


        //creating File instance to reference text file in Java
        File text = new File("C:/Users/Rashid/Desktop/mosquitoes.txt");


        //Creating Scanner instnace to read File in Java
        Scanner scnr = new Scanner(text);


        //Reading each line of file using Scanner class
        int lineNumber = 1;
        int i=0;
        //while(scnr.hasNextLine()){
        //    String line = scnr.nextLine();
        //    System.out.println("line " + lineNumber + " :" + line);
        //    lineNumber++;
        //}

        try {
            Scanner s = new Scanner(text);
            int lineNo = 1;

            // Create new file
            String content = "This is the content to write into create ";
            String path = "C:/Users/Rashid/Desktop/mosquitoes2.txt";
            File file = new File(path);


            // If file doesn't exists, then create it
            if (!file.exists()) {
                file.createNewFile();
            }


            FileWriter fw = new FileWriter(file.getAbsoluteFile());
            BufferedWriter bw = new BufferedWriter(fw);


            // Write in file
            //bw.write(content);
            while(scnr.hasNextLine()){
                String line = scnr.nextLine();
                String[] split = line.trim().split("\\s+");
                System.out.print("times ["+ (lineNumber-2)+"] = "+split[3]+";f\n");
                //System.out.println("line " + lineNumber + " :" + line);
                bw.write("times [" + (lineNumber - 2) + "] = " + split[3] + "f;\n");
                lineNumber++;
            }


            // Close connection
            bw.close();
        } catch (IOException e) {
            System.out.println(e);
        }
    }
}







