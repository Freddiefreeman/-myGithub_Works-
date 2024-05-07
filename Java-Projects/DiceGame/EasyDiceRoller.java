package DiceGame;

import java.util.Scanner;

public class EasyDiceRoller {

    public static void main(String[] args) {
        Scanner userInput;
        
        userInput = new Scanner(System.in);
        System.out.println("Welcome to the DICE GAME™\n\nDice Game Starting up...");
        
        System.out.print("How many rounds? ");
        int rounds = userInput.nextInt();
        
        System.out.print("How many sides on the die? ");
        //userInput = new Scanner(System.in);
        int sides = userInput.nextInt();
        userInput.nextLine();
        
        System.out.print("What is your name? ");
        String name = userInput.nextLine();
        Player player1 = new Player(name);
        player1.addDie(sides);

        for (int i = 0; i < rounds; i++) {
            System.out.print("What number will be displayed on roll " + (i+1) + "?: ");
            userInput = new Scanner(System.in);
            int guessNumber = userInput.nextInt();
            player1.rollDice();
            if (guessNumber == player1.getDieValue())
            {
                player1.increaseScore();
                System.out.println(rollOutputString(i, player1, "{CORRECT!}"));
            }
            else
            {
                System.out.println(rollOutputString(i, player1, "{Miss...}"));
            }
        }
        System.out.println("\nYou scored " + player1.getScore() + " out of " + rounds + " rounds \nDICE GAME™ Shutting down..");
        userInput.close();
    }

    public static String rollOutputString(int i, Player player1, String result)
    {
        return "On roll " + (i+1) + ", " + player1.getName() + " you rolled: " + player1.getDieValue() + " " + result;
    }
}
