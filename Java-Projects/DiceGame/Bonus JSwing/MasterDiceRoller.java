package DiceGame;

import javax.swing.*;
import javax.swing.border.TitledBorder;

import java.awt.*;
import java.awt.event.*;
import java.util.Random;

public class MasterDiceRoller 
{
    private static class NumberOrder //This was created only for the sole purpose for an increment function to the "actionlistener"
    {
        private int number;
        public NumberOrder()
        {
            this.number = 0;
        }
        public void increment()
        {
            this.number++;
        }
        public int getValue()
        {
            return this.number;
        }
        public void setValue(int n)
        {
            this.number = n;
        }
    }
    
    public static void main(String[] args) 
    {
        //Non-JFrame
        Random dice = new Random();
        NumberOrder numbOrder = new NumberOrder();
        
        //Establish the UI skeleton
        JFrame frame = new JFrame("Master Dice roller");
        JPanel mainPanel = new JPanel();
        JPanel diceTextPanel = new JPanel();
        JPanel logPanel = new JPanel();
        JPanel diceButtonPanel = new JPanel();
        JPanel modifierPanel = new JPanel();
        JLabel text = new JLabel("Please Choose one of the dice options below and roll.");
        JTextField customNumber = new JTextField(10);
        JTextField diceAmount = new JTextField("1", 5);

        //This is all established Buttons that we then make a 'ButtonGroup' out of to make use of the 'JRadioButton' system.
        JButton rollButton = new JButton("Roll!");
        JRadioButton radioD6 = new JRadioButton("D6");
        JRadioButton radioD20 = new JRadioButton("D20");
        JRadioButton radioCustom = new JRadioButton("D");
        JButton resetButton = new JButton("Reset");
        ButtonGroup diceGroup = new ButtonGroup();
        JButton addDice = new JButton("+");
        JButton subtractDice = new JButton("-");
        ButtonGroup modifierGroup = new ButtonGroup();

        //This establishes a log list where we can archive every roll
        JTextArea diceLog = new JTextArea(10,30);
        JScrollPane scrollLog = new JScrollPane(diceLog);
        JTextArea lines = new JTextArea();

        //UI Parameter for Frame 
        frame.setSize(700,500);

        //UI Parameters/Layout for Panels

        //Main Panel - We Establish it with a "GridLayout" (Search java document example) and give it 2 rows and 1 column
        mainPanel.setBorder(new TitledBorder("Dice Roller"));
        mainPanel.setLayout(new GridLayout(2,1));
        frame.add(mainPanel);

        //Top Left
        diceTextPanel.setLayout(new GridLayout(1,1));
        diceTextPanel.add(text);
        mainPanel.add(diceTextPanel);

        //Top Right
        logPanel.setLayout(new BoxLayout(logPanel, BoxLayout.Y_AXIS));;
        logPanel.add(scrollLog);
        logPanel.add(resetButton);
        scrollLog.setRowHeaderView(lines);
        mainPanel.add(logPanel);
        
        //Bottom Left
        diceButtonPanel.setLayout(new FlowLayout());
        diceButtonPanel.add(rollButton);
        diceButtonPanel.add(radioD6);
        diceButtonPanel.add(radioD20);
        diceButtonPanel.add(radioCustom);
        diceButtonPanel.add(customNumber);
        mainPanel.add(diceButtonPanel);

        //Bottom Right
        modifierPanel.setLayout(new FlowLayout());
        modifierPanel.add(addDice);
        modifierPanel.add(subtractDice);
        modifierPanel.add(diceAmount);
        mainPanel.add(modifierPanel);

        lines.setBackground(Color.LIGHT_GRAY);
        lines.setEditable(false);
        //log.setSize(400, 1000);
        
        //ButtonGroups in order: 1. Dice Choices  2. Modifiers
        diceGroup.add(radioD6);
        diceGroup.add(radioD20);
        diceGroup.add(radioCustom);

        modifierGroup.add(addDice);
        modifierGroup.add(subtractDice);
        
        frame.setVisible(true);

        rollButton.addActionListener(new ActionListener() 
        {
            public void actionPerformed(ActionEvent e) 
            {
                if (radioD6.isSelected())
                {
                    int diceD6 = dice.nextInt(6) + 1;
                    numbOrder.increment();
                    text.setVisible(true);
                    System.out.println("The Terminal Rolled from a D6: " + diceD6);
                    text.setText("You rolled: " + diceD6);
                    diceLog.append("\n You rolled from a D6: " + diceD6);
                    lines.append("\n" + numbOrder.getValue());
                    if (diceD6 == 6)
                    {
                        text.setText("You rolled a " + diceD6 + ", Critical Hit!");
                        diceLog.append("\r, Critical Hit!");
                    }
                    else if (diceD6 == 1)
                    {
                        text.setText("Oh no! You rolled a " + diceD6 + ", Critical Miss!");
                        diceLog.append("\r, Critical Miss!");
                    }
                }
                else if(radioD20.isSelected())
                {
                    int diceD20 = dice.nextInt(20) + 1;
                    numbOrder.increment();
                    text.setVisible(true);
                    System.out.println("The Terminal Rolled from a D20: " + diceD20);
                    text.setText("You rolled: " + diceD20);
                    diceLog.append("\n You rolled from a D20: " + diceD20);
                    lines.append("\n" + numbOrder.getValue());
                    if (diceD20 == 20)
                    {
                        text.setText("You rolled a NAT " + diceD20 + ", Critical Hit!");
                        diceLog.append("\r, Critical hit!");
                    }
                    else if (diceD20 == 1)
                    {
                        text.setText("Oh no! You rolled a NAT " + diceD20 + ", Critical Miss!");
                        diceLog.append("\r, Critical Miss!");
                    }
                }
                else if(radioCustom.isSelected()) //Could be improved methinks.
                {
                    String customDiceNum = customNumber.getText();
                    int customDice = Integer.parseInt(customDiceNum);
                    int diceCustom = dice.nextInt(customDice) + 1;
                    numbOrder.increment();
                    text.setVisible(true);
                    System.out.println("The Terminal Rolled from a D" + customDiceNum + ": " + diceCustom);
                    text.setText("You rolled: " + diceCustom);
                    diceLog.append("\n You rolled from a D" + customNumber.getText() + ": " + diceCustom);
                    lines.append("\n" + numbOrder.getValue());
                }
                else;
            }
        });

        addDice.addActionListener(new ActionListener() 
        {
            public void actionPerformed(ActionEvent e) 
            {
                if (e.getSource() == addDice)
                {
                    String diceAmountNum = diceAmount.getText();
                    int diceRolls = Integer.parseInt(diceAmountNum);
                    //diceRolls.setText(1);   
                }
            }
        });

        resetButton.addActionListener(new ActionListener() 
        {
            public void actionPerformed(ActionEvent e) 
            {
                if (e.getSource() == resetButton)
                {
                    text.setVisible(false);
                    text.setText("");
                    diceLog.setText("");
                    lines.setText("");
                    numbOrder.setValue(0);
                }
            }
        });
    }
}
