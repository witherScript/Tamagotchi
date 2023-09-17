using System.Timers;
using System;
using System.Windows.Forms;

namespace Tamagotchi.Models
{
  public class Tamagotchi
  {
    private ProgressBar hungerBar;
    private ProgressBar boredomBar;
    private ProgressBar sleepinessBar;
    private ProgressBar ageBar;

    public ProgressBars()
    {
      IntializeComponents();
      hungerBar = new ProgressBar();
      boredomBar = new ProgressBar();
      sleepinessBar = new ProgressBar();
      ageBar = new ProgressBar();
      
      hungerBar.Maximum = 100;
      hungerBar.Value = 100;

      boredomBar.Maximum = 100;
      boredomBar.Value = 100;

      sleepinessBar.Maximum = 100;
      sleepinessBar.Value = 100;

      ageBar.Maximum = 100;
      ageBar.Value = 100;

      Controls.Add(hungerBar);
      Controls.Add(boredomBar);
      Controls.Add(sleepinessBar);
      Controls.Add(ageBar);

      timer = new Timer();
      timer.Interval = 1000;
      timer.Tick += Timer_Tick;
      timer.Start();

      feedButton = new Button();
      feedButton.Text = "Feed";
      feedButton.Click += FeedButton_Click;
      Controls.Add(feedButton);

      playButton = new Button();
      playButton.Text = "Play";
      playButton.Click += PlayButton_Click;
      Controls.Add(playButton);   

      sleepButton = new Button();
      sleepButton.Text = "Sleep";
      sleepButton.Click += SleepButton_Click;
      Controls.Add(sleepButton);
    }

  }

  private void Timer_Tick(object sender, EventArgs e)
  {
    if (hungerBar.Value == 0 || boredomBar.Value == 0 || sleepinessBar.Value == 0 || ageBar.Value == 0)
    {
      timer.Stop();
      MessageBox.Show("Your Tamagotchi has died!");
    }
    else
    {
      hungerBar.Value -= 1;
      boredomBar.Value -= 1;
      sleepinessBar.Value -= 1;
      ageBar.Value -= 1;

       webBrowser.Document.InvokeScript("updateTamagotchi", new object[] { hungerBar.Value, boredomBar.Value, sleepinessBar.Value, ageBar.Value });
    }
  }
}