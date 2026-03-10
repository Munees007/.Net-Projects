using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
namespace RockPaperScissor
{
    public partial class _Default : Page
    {
        Random rand = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblResult.Text = "Choose Rock, Paper, or Scissors!";
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Debug.WriteLine("Page_PreInit event completed");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
           Debug.WriteLine("Page_Init event completed");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Debug.WriteLine("Page_InitComplete event completed");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblPreInit.Text = "Completed";
            lblInit.Text = "Completed";
            lblInitComplete.Text = "Completed";
            lblLoad.Text = "Completed";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            lblLoadComplete.Text = "Completed";
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            lblPreRender.Text = "Completed";
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            lblPreRenderComplete.Text = "Completed";
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            lblSaveStateComplete.Text = "Completed";
        }

        protected void PlayGame(object sender, EventArgs e)
        {
            lblButtonClick.Text = "Completed";

            // Get user's choice
            string userChoice = ((System.Web.UI.WebControls.Button)sender).Text;

            // Generate computer choice
            string[] choices = { "🪨 Rock", "📄 Paper", "✂️ Scissors" };
            string computerChoice = choices[rand.Next(3)];

            // Display choices
            lblUser.Text = "You: " + userChoice;
            lblComputer.Text = "Computer: " + computerChoice;

            // Determine winner
            if (userChoice == computerChoice)
            {
                lblResult.Text = "It's a Draw!";
            }
            else if (
                (userChoice.Contains("🪨") && computerChoice.Contains("✂️")) ||
                (userChoice.Contains("📄") && computerChoice.Contains("🪨")) ||
                (userChoice.Contains("✂️") && computerChoice.Contains("📄"))
            )
            {
                lblResult.Text = "You Win! 🎉";
            }
            else
            {
                lblResult.Text = "Computer Wins!";
            }
        }
    }
}