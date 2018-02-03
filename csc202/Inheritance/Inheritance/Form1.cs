using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
  {
  public partial class Form1 : Form
    {
    Character character = new Character();
    NPC       npc       = new NPC();
    Player    player    = new Player();

    public Form1()
      {
      InitializeComponent();
      
      /** Initialize the labels. */
      lblCharacterDisplay.Text = character.stringify;
      lblNPCDisplay.Text       = npc      .stringify;
      lblPlayerDisplay.Text    = player   .stringify;
      }

    private void Form1_Load(object sender, EventArgs e)
      {
      }

    /**************************************************************************
    * Character
    **************************************************************************/
    /**************************************************************************
    * rbCharacterClass_CheckedChanged
    * 
    * Updates the Character object's class.
    **************************************************************************/
    private void rbCharacterClass_CheckedChanged(object sender, EventArgs e)
      {
      character.clazz = sender == rbCharacterFighter ? Character.FIGHTER :
                        sender == rbCharacterMonk    ? Character.MONK    : Character.WIZARD;
      
      lblCharacterDisplay.Text = character.stringify;
      }

    /**************************************************************************
    * rbCharacterIsAlive_CheckedChanged
    * 
    * Updates the Character object's isAlive flag.
    **************************************************************************/
    private void rbCharacterIsAlive_CheckedChanged(object sender, EventArgs e)
      {
      character.alive = sender == rbCharacterAliveYes;
      lblCharacterDisplay.Text = character.stringify;
      }

    /**************************************************************************
    * tbCharacterName_TextChanged
    * 
    * Updates the Character object's name.
    **************************************************************************/
    private void tbCharacterName_TextChanged(object sender, EventArgs e)
      {
      character.name = tbCharacterName.Text;
      lblCharacterDisplay.Text = character.stringify;
      }

    /**************************************************************************
    * NPC
    **************************************************************************/
    /**************************************************************************
    * rbNPCClass__CheckedChanged
    * 
    * Updates the NPC object's class.
    **************************************************************************/
    private void rbNPCClass__CheckedChanged(object sender, EventArgs e)
      {
      npc.clazz = sender == rbNPCFighter ? Character.FIGHTER :
                  sender == rbNPCMonk    ? Character.MONK    : Character.WIZARD;
      lblNPCDisplay.Text = npc.stringify;
      }

    /**************************************************************************
    * rbNPCEmotion_CheckedChanged
    * 
    * Updates the NPC object's emotion.
    **************************************************************************/
    private void rbNPCEmotion_CheckedChanged(object sender, EventArgs e)
      {
      npc.emotion = sender == rbNPCHappy ? NPC.HAPPY : sender == rbNPCSad ? NPC.SAD : NPC.ANGRY;
      lblNPCDisplay.Text = npc.stringify;
      }

    /**************************************************************************
    * rbNPCIsAlive_CheckedChanged
    * 
    * Updates the NPC object's isAlive flag.
    **************************************************************************/
    private void rbNPCIsAlive_CheckedChanged(object sender, EventArgs e)
      {
      npc.alive = sender == rbNPCAliveYes;
      lblNPCDisplay.Text = npc.stringify;
      }

    /**************************************************************************
    * rbNPCIsGood_CheckedChanged
    * 
    * Updates the NPC object's isGood flag.
    **************************************************************************/
    private void rbNPCIsGood_CheckedChanged(object sender, EventArgs e)
      {
      npc.isGood = sender == rbNPCIsGoodYes;
      lblNPCDisplay.Text = npc.stringify;
      }

    /**************************************************************************
    * tbNPCName_TextChanged
    * 
    * Updates the NPC object's name.
    **************************************************************************/
    private void tbNPCName_TextChanged(object sender, EventArgs e)
      {
      npc.name = tbNPCName.Text;
      lblNPCDisplay.Text = npc.stringify;
      }

    /**************************************************************************
    * Player
    **************************************************************************/
    /**************************************************************************
    * rbPlayerClass_CheckedChanged
    * 
    * Updates the Player object's class.
    **************************************************************************/
    private void rbPlayerClass_CheckedChanged(object sender, EventArgs e)
      {
      player.clazz = sender == rbPlayerFighter ? Character.FIGHTER :
                     sender == rbPlayerMonk    ? Character.MONK    : Character.WIZARD;
      lblPlayerDisplay.Text = player.stringify;
      }

    /**************************************************************************
    * rbPlayerIsAlive_CheckedChanged
    * 
    * Updates the Player object's isAlive flag.
    **************************************************************************/
    private void rbPlayerIsAlive_CheckedChanged(object sender, EventArgs e)
      {
      player.alive = sender == rbPlayerAliveYes;
      lblPlayerDisplay.Text = player.stringify;
      }

    /**************************************************************************
    * tbPlayerExperience_Leave
    * 
    * Updates the Player object's experience.
    **************************************************************************/
    private void tbPlayerExperience_Leave(object sender, EventArgs e)
      {
      int xp;
      
      if(!int.TryParse(tbPlayerExperience.Text, out xp))
        {
        MessageBox.Show("Invalid value for Experience...");
        return;
        }

      player.experience = xp;
      lblPlayerDisplay.Text = player.stringify;
      }

    /**************************************************************************
    * tbPlayerLives_Leave
    * 
    * Updates the Player object's lives.
    **************************************************************************/
    private void tbPlayerLives_Leave(object sender, EventArgs e)
      {
      int lives;
      
      if(!int.TryParse(tbPlayerLives.Text, out lives))
        {
        MessageBox.Show("Invalid value for Lives...");
        return;
        }

      player.livesRemaining = lives;
      lblPlayerDisplay.Text = player.stringify;
      }

    /**************************************************************************
    * tbPlayerName_TextChanged
    * 
    * Updates the Player object's name.
    **************************************************************************/
    private void tbPlayerName_TextChanged(object sender, EventArgs e)
      {
      player.name = tbPlayerName.Text;
      lblPlayerDisplay.Text = player.stringify;
      }
    }
  }
