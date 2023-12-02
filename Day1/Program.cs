using System.IO;
using System.Text.RegularExpressions;

// quite simply put, i am a skill issue and couldnt get far at all.
// this is fuckin part 1

// my fucking brain couldnt figure out how to 
// - get the first and last digit of each line
// - and if there's only 1 digit on that line, basically add it on to each other

// at least i got it to read, write, strip out the text, and sum it all up but wow i feel kinda stupid
// if i do AoC 2023 day 2 i hope it goes better for me otherwise i am just fucked tbh.

// - am-p

public class Day1 {
    static String line;
    static String dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
    static String relativeInputFile = $"{dir}/input.txt";
    static String relativeOutputFile = $"{dir}/output.txt";
    
    public static void Problem() {
        try {
            StreamReader sr = new(relativeInputFile);
            StreamWriter sw = new(relativeOutputFile);
            line = sr.ReadLine();
            while (line != null) {
                String numOnly = Regex.Replace(line, "[^0-9.]", "");
                Console.WriteLine(numOnly);
                sw.WriteLine(numOnly);
                line = sr.ReadLine();
            }

            sr.Close();
            sw.Close();
        } catch (Exception e) {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }

    public static void Answer() {
        int sum = File.ReadAllLines(relativeOutputFile).Sum(x => int.Parse(x));
        Console.WriteLine($"The Total Sum is: {sum}");
    }

    public static void Main(String[] args) {
        Problem();
        Answer();
    }
}