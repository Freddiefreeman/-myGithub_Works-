package DiceGame;

import java.util.Scanner;
import java.util.ArrayList;

public class EasyDiceRoller_Multiplayer {
    public static void main(String[] args) {
        Scanner userInput;
        ArrayList<Player> playerList = new ArrayList<Player>();

        userInput = new Scanner(System.in);
        System.out.println("Welcome to the DICE GAME™\nDice Game Starting up...");

        System.out.print("How many players? ");
        int amountPlayers = userInput.nextInt();

        System.out.print("How many Dice? ");
        int amountDice = userInput.nextInt();

        System.out.print("How many sides on the die? ");
        // userInput = new Scanner(System.in);
        int sides = userInput.nextInt();

        System.out.print("How many rounds? ");
        int rounds = userInput.nextInt();

        if (amountPlayers < 1 || amountDice < 1 || sides < 1 || rounds < 1) {
            System.out.print("Insufficient Input! DICE GAME™ shutting down...");
        } else {
            for (int p = 0; p < amountPlayers; p++) // 'p' for Players
            {
                userInput = new Scanner(System.in);
                System.out.print("What is your name? ");
                String name = userInput.nextLine();
                Player p1 = new Player(name);
                playerList.add(p1);
                for (int d = 0; d < amountDice; d++) {
                    p1.addDie(sides);
                }
            }

            for (int i = 0; i < rounds; i++) {
                System.out.println("On round " + (i + 1) + ":");
                for (int p = 0; p < playerList.size(); p++) // 'p' for Players
                {
                    Player player1 = playerList.get(p);
                    player1.rollDice();
                    System.out
                            .println("Player {" + player1.getName() + "}, You scored: " + player1.getDieValue() + "\n");
                    player1.increaseScore(player1.getDieValue());
                }
            }

            resultOutput(playerList);

            Player winner = findWinner(playerList);
            System.out.println("\n{" + winner.getName() + "} You win!");
        }
        userInput.close();
    }

    static void resultOutput(ArrayList<Player> playerList) {
        System.out.println("\n|FINAL SCORE| ");
        for (Player p : playerList) {
            System.out.println(p.getName() + ", Your Total Score: " + p.getScore());
        }
    }

    static Player findWinner(ArrayList<Player> playerList) {
        Player winningPlayer = null;
        int highestScore = Integer.MIN_VALUE;
        for (Player p : playerList) // 'p' for players
        {
            if (p.getScore() > highestScore) {
                highestScore = p.getScore();
                winningPlayer = p;
            }
        }
        return winningPlayer;
    }
}
