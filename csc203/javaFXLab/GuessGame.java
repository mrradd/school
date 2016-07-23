
/*******************************************************************************
* Conrad Horton
* CISC203 June 2016
* JavaFX Lab Part3 Guess Game
* 20170717
*******************************************************************************/

package rad;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

/*******************************************************************************
* Class FXOne */
/**
*******************************************************************************/
class GuessGame extends JFrame
  {
  private static Random mRand = new Random();
  private int           mNumber;
  private int           mGuessCount;
  private int           mLastDistance;
  private JTextField    mGuessInputTextField;
  private JLabel        mPrompt1Label;
  private JLabel        mPrompt2Label;
  private JLabel        mMessageLabel;
  private JButton       mNewGameButton;
  private Color         mBackGround;

  /*****************************************************************************
  * CTOR */
  /**
  *****************************************************************************/
  public GuessGame()
    {
    mGuessCount = 0;
    mBackGround = Color.LIGHT_GRAY;
    
    /** Make labels. **/
    mPrompt1Label = new JLabel("Guess a number from 1-1000.");
    mPrompt2Label = new JLabel("Enter your guess: ");
    mMessageLabel = new JLabel("Guess result appears here.");
    
    /** Make text field. **/
    mGuessInputTextField = new JTextField(5);
    
    /** Make new game button. **/
    mNewGameButton = new JButton("New Game");
    
    /** Add action listeners. **/
    /** Add text listener. **/
    mGuessInputTextField.addActionListener(new ActionListener()
      {
      public void actionPerformed(ActionEvent e)
        {
        String  t = mGuessInputTextField.getText();
        Integer i = Integer.parseInt(t);
        react(i.intValue());
        }
      });
    
    /** Add new button listener. **/
    mNewGameButton.addActionListener(new ActionListener()
      {
      public void actionPerformed(ActionEvent e)
        {
        mBackGround   = Color.LIGHT_GRAY;
        mGuessCount   = 0;
        mLastDistance = 0;
        mNumber       = mRand.nextInt(1000);

        mGuessInputTextField.setText("");
        paint(getGraphics());
        }
      });
    
    setLayout(new GridLayout(5,1));
    add(mPrompt1Label);
    add(mPrompt2Label);
    add(mGuessInputTextField);
    add(mMessageLabel);
    add(mNewGameButton);
    theGame();
    }

  /*****************************************************************************
  * paint */
  /**
  * Change background color.
  *****************************************************************************/
  public void paint(Graphics g)
    {
    super.paint(g);
    getContentPane().setBackground(mBackGround);
    }

  /*****************************************************************************
  * react */
  /**
  * React to the new guess.
  * @param  guess  User's guess.
  *****************************************************************************/
  public void react(int guess)
    {
    mGuessCount++;
    
    /** Successful guess. **/
    if (mNumber == guess)
      {
      mBackGround = Color.GRAY;
      mMessageLabel.setText("Correct!");      
      return;
      }
    
    /** Change background color. **/
    int d = Math.abs(guess - mNumber);
    if (d > mLastDistance)
      {
      mBackGround = Color.BLUE;
      mMessageLabel.setText("Getting colder.");
      }
    else if (d < mLastDistance)
      {
      mBackGround = Color.RED;
      mMessageLabel.setText("Getting warmer.");
      }
    
    /** Update last distance. **/
    mLastDistance = d;
    
    /** Repaint. **/
    paint(this.getGraphics());
    repaint();
    }
  
  /*****************************************************************************
  * theGame */
  /**
  * Run the game.
  *****************************************************************************/
  public void theGame()
    {
    mNumber       = mRand.nextInt(1000);
    mLastDistance = 0;
    }
  
  public static void main(String args[])
    {
    GuessGame gg = new GuessGame();
    gg.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    gg.setSize(400, 200);
    gg.setVisible(true);
    }
  }