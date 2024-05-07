package DiceGame;

import java.util.ArrayList;

class Player {
    private String name;
    private int score;
    private ArrayList<Die> myDice;

    Player(String name) {
        this.name = name;
        this.score = 0;
        this.myDice = new ArrayList<Die>();
    }

    public String getName() {
        return name;
    }

    public void rollDice() {
        for (Die d : myDice) { //'d' for dice
            d.roll();
        }
    }

    public int getDieValue() {
        int totalValue = 0;
        for (Die v : myDice) { //'v' for value
            totalValue += v.getValue();
        }
        return totalValue;
    }

    public int getScore() {
        return score;
    }

    public void increaseScore()
    {
        this.score += 1;
    }

    public void increaseScore(int score) {
        this.score += score;
    }

    public void addDie(int sides) {
        myDice.add(new Die(sides));
    }
}