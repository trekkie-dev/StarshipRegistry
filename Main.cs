using System.Media;
using System.Runtime.InteropServices;

namespace StarshipRegistryGUI;

public partial class mainForm : Form
    {

    #region Form Specific Methods
    // corner rounding
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    readonly Splash Spl;
    private bool acceptBtnClick;

    public mainForm(Splash spl)
        {
        InitializeComponent();
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // corner rounding
        Spl = spl;


        // field visibility at start
        inputText.Visible = false;
        selectionLabel.Visible = false;
        outputTextBox.Visible = false;

        }

    public mainForm()
        {
        }

    private void mainForm_Load(object sender, EventArgs e)
        {
        // show screen sound
        SoundPlayer sPlayer = new SoundPlayer(@"c:\users\Chris\Downloads\scrshow.wav");
        sPlayer.Play();

        // adjust heading font size
        headingLabel.Font = new Font("Antonio", 36.0f, FontStyle.Regular);

        // pulls username from the Splash
        headingLabel.Text = Spl.splNameInput.Text;

        this.dynamicPhotoBox.Show();
        this.headingLabel.Text = "WELCOME CAPTAIN " + Spl.splNameInput.Text;

        this.appTitleLabel.Text = "LCARS / INFORMATIONAL DATABASE ACCESS";

        dynamicPhotoBox.Image = Image.FromFile(@"G:\Code Kentucky Projects\StarshipRegistryGUI\Resources\UFP2390s.png");

        infoTextBox.Visible = true;
        infoTextBox.Text = "UNITED FEDERATION OF PLANETS • SAN FRANCISCO • EARTH • SOL SYSTEM • STARDATE: " + calculateStardate();
        }

    #endregion





    #region Main Navigation
    public void accessBtn_Click(object sender, EventArgs e)
        {

        // helper methods
        primeElementVisibility();
        homeScreenElementVisibility();
        clearAllTextFields();
        focusOnInput();

        randomKeySound(); // plays a random sound when buttons are pressed

        this.appTitleLabel.Text = "LCARS / DATABASE OF IDENTIFIED STARSHIPS";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "DATABASE OF IDENTIFIED STARSHIPS";
        selectionLabel.Text = "SEARCH PARAMETERS:";

        this.inputText.PlaceholderText = "SEARCH VESSEL BY NAME OR ABBREVIATION     EX. 'ENTERPRISE' OR 'ENT'";


        }

    private void scienceButton_Click(object sender, EventArgs e)
        {
        randomKeySound(); // plays a random sound when buttons are pressed
        appTitleLabel.Text = "LCARS / SCIENTIFIC DATABASE";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "SCIENTIFIC DATABASE";
        selectionLabel.Text = "SEARCH PARAMETERS:";
        }

    private void techButton_Click(object sender, EventArgs e)
        {
        randomKeySound(); // plays a random sound when buttons are pressed
        appTitleLabel.Text = "LCARS / TECHNOLOGICAL DATABASE";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "TECHNOLOGICAL DATABASE";
        selectionLabel.Text = "SEARCH PARAMETERS:";
        }

    private void cultureButton_Click(object sender, EventArgs e)
        {
        randomKeySound(); // plays a random sound when buttons are pressed
        appTitleLabel.Text = "LCARS / CULTURAL DATABASE";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "CULTURAL DATABASE";
        selectionLabel.Text = "SEARCH PARAMETERS:";
        }

    private void galaxyMapButton_Click(object sender, EventArgs e)
        {
        randomKeySound(); // plays a random sound when buttons are pressed

        dynamicPhotoBox.Visible = false;
        headingLabel.Visible = false;
        infoTextBox.Visible = false;

        appTitleLabel.Text = "LCARS / ASTROMETRIC CARTOGRAPHY";
        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);



        }
    private void exitBtn_Click(object sender, EventArgs e)
        {

        // exit program audio indicator
        SoundPlayer sPlayer = new SoundPlayer(@"c:\users\Chris\Downloads\communications_end_transmission.wav");
        sPlayer.PlaySync();

        Application.Exit(); // exits the program
        }
    #endregion





    #region Secondary Navigation

    public void confirmButton_Click(object sender, EventArgs e)
        {
        Focus();

        starshipSearch();

        }

    private void clearButton_Click(object sender, EventArgs e)
        {
        randomKeySound(); // plays a random sound when buttons are pressed

        inputText.Clear();
        outputTextBox.Clear();
        focusOnInput();
        }
    #endregion





    #region App Methods
    /// <summary>
    /// STARSHIP SEARCH METHOD
    /// </summary>
    public void starshipSearch()
        {
        Starships enterprise = new Starships("United Federation of Planets", "Galaxy Class", "NCC-1701-D", "USS Enterprise", "Jean-Luc Picard", "Warp 7", "Warp 9.8", "1000-6000 Crew Members", false);
        Starships defiant = new Starships("United Federation of Planets", "Defiant Class", "NX-72405", "USS Defiant", "Benjamin Lafayette Sisko", "Warp 6", "Warp 9.5", "50 Crew Members", true);
        Starships voyager = new Starships("United Federation of Planets", "Intrepid Class", "NCC-74656", "USS Voyager", "Kathryn Janeway", "Warp 6", "Warp[ 9.975", "200 Crew Members", false);

        // Klingon
        Starships rotarran = new Starships("Klingon Empire", "Bird of Prey", "IKC-92127", "IKS Rotarran", "General Martok", "Warp 6.5", "Warp 8", "12 Warriors", false);

        String shipEntry = inputText.Text.ToUpper();

        switch (shipEntry)
            {
            case "ENTERPRISE":
            case "ENT":
            case "ENTERPRISE D":
            case "NCC 1701-D":
                acceptedInput();
                dynamicPhotoBox.Visible = true;
                dynamicPhotoBox.Image = Image.FromFile(@"G:\Code Kentucky Projects\StarshipRegistryGUI\Resources\photos\ncc-1701-d.jpg");

                outputTextBox.Text = "SHIP DESIGNATION:   " + enterprise.shipName.ToUpper() + "\r\n" +
                                                   "AFFILIATION:   " + enterprise.affiliation.ToUpper() + "\r\n" +
                                                   "CLASS:   " + enterprise.shipClass.ToUpper() + "\r\n" +
                                                   "REGISTRY NUMBER:   " + enterprise.regNum.ToUpper() + "\r\n" +
                                                   "MOST RECENT CAPTAIN:   " + enterprise.currentCaptain.ToUpper() + "\r\n" +
                                                   "CRUISING SPEED:   " + enterprise.cruiseSpeed.ToUpper() + "\r\n" +
                                                   "TOP SPEED:   " + enterprise.topSpeed.ToUpper() + "\r\n" +
                                                   "CREW COMPLIMENT:   " + enterprise.crewComp.ToUpper() + "\r\n" +
                                                   "EXPERIMENTAL VESSEL:   " + enterprise.isExperimental;
                break;

            case "DEFIANT":
            case "DEF":
                acceptedInput();
                outputTextBox.Text = "SHIP DESIGNATION:   " + defiant.shipName.ToUpper() + "\r\n" +
                                                   "AFFILIATION:   " + defiant.affiliation.ToUpper() + "\r\n" +
                                                   "CLASS:   " + defiant.shipClass.ToUpper() + "\r\n" +
                                                   "REGISTRY NUMBER:   " + defiant.regNum.ToUpper() + "\r\n" +
                                                   "MOST RECENT CAPTAIN:   " + defiant.currentCaptain.ToUpper() + "\r\n" +
                                                   "CRUISING SPEED:   " + defiant.cruiseSpeed.ToUpper() + "\r\n" +
                                                   "TOP SPEED:   " + defiant.topSpeed.ToUpper() + "\r\n" +
                                                   "CREW COMPLIMENT:   " + defiant.crewComp.ToUpper() + "\r\n" +
                                                   "EXPERIMENTAL VESSEL:   " + defiant.isExperimental;
                break;

            case "VOYAGER":
            case "VOY":
                acceptedInput();
                outputTextBox.Text = "SHIP DESIGNATION:   " + voyager.shipName.ToUpper() + "\r\n" +
                                                   "AFFILIATION:   " + voyager.affiliation.ToUpper() + "\r\n" +
                                                   "CLASS:   " + voyager.shipClass.ToUpper() + "\r\n" +
                                                   "REGISTRY NUMBER:   " + voyager.regNum.ToUpper() + "\r\n" +
                                                   "MOST RECENT CAPTAIN:   " + voyager.currentCaptain.ToUpper() + "\r\n" +
                                                   "CRUISING SPEED:   " + voyager.cruiseSpeed.ToUpper() + "\r\n" +
                                                   "TOP SPEED:   " + voyager.topSpeed.ToUpper() + "\r\n" +
                                                   "CREW COMPLIMENT:   " + voyager.crewComp.ToUpper() + "\r\n" +
                                                   "EXPERIMENTAL VESSEL:   " + voyager.isExperimental;
                break;

            case "ROTARRAN":
            case "ROT":
                acceptedInput();
                outputTextBox.Text = "SHIP DESIGNATION:   " + rotarran.shipName.ToUpper() + "\r\n" +
                                                   "AFFILIATION:   " + rotarran.affiliation.ToUpper() + "\r\n" +
                                                   "CLASS:   " + rotarran.shipClass.ToUpper() + "\r\n" +
                                                   "REGISTRY NUMBER:   " + rotarran.regNum.ToUpper() + "\r\n" +
                                                   "MOST RECENT CAPTAIN:   " + rotarran.currentCaptain.ToUpper() + "\r\n" +
                                                   "CRUISING SPEED:   " + rotarran.cruiseSpeed.ToUpper() + "\r\n" +
                                                   "TOP SPEED:   " + rotarran.topSpeed.ToUpper() + "\r\n" +
                                                   "CREW COMPLIMENT:   " + rotarran.crewComp.ToUpper() + "\r\n" +
                                                   "EXPERIMENTAL VESSEL:   " + rotarran.isExperimental;
                break;

                /*default:
                    outputTextBox.Text = "STARSHIP " + shipEntry.ToUpper() + " WAS NOT FOUND. PLEASE CHECK THE SHIP'S IDENTIFICATION AND TRY AGAIN";
                    break;*/
            }
        }

    public void sciDatabase()
        {

        }

    public void techDatabase()
        {

        }

    public void culDatabase()
        {

        }
    public void astroCarto()
        {

        }

    #endregion





    #region Support Methods

    // clears text fields and labels when button is clicked
    private void clearAllTextFields()
        {
        headingLabel.Text = String.Empty;
        inputText.Text = String.Empty;
        selectionLabel.Text = String.Empty;
        outputTextBox.Text = String.Empty;
        }

    // focuses cursor on text input boxes
    private void focusOnInput()
        {
        this.inputText.Focus();
        }

    // sets visiiblity of text fields on Access & Register screens
    private void primeElementVisibility()
        {
        inputText.Visible = true;
        //headingLabel.Visible = true;
        selectionLabel.Visible = true;
        outputTextBox.Visible = true;
        }

    private void homeScreenElementVisibility()
        {
        dynamicPhotoBox.Visible = false;

        }



    /// <summary>
    /// CONVERTS THE DATE INTO STARDATE
    /// </summary>
    public double calculateStardate()
        {
        DateTime calenderStarTrek = new DateTime(2323, 1, 1, 0, 0, 0);
        DateTime presentLocalDate = DateTime.Now;
        presentLocalDate = presentLocalDate.AddYears(377);

        TimeSpan timeOffset = presentLocalDate - calenderStarTrek;
        double yearValue = timeOffset.TotalMilliseconds / (60 * 60 * 24 * 365.2422);
        double stardate = Math.Floor(yearValue * 100);
        stardate = stardate / 100;

        return stardate;
        }



    /// <summary>
    /// PLAYS SOUND FOR ACCEPTED INPUT
    /// </summary>
    public void acceptedInput()
        {
        SoundPlayer enterPress = new SoundPlayer(@"c:\users\Chris\Downloads\input_ok_2_clean.wav");
        enterPress.Play();
        }



    /// <summary>
    /// PLAYS A RANDOM SOUND WHEN BUTTONS ARE PRESSED
    /// </summary>
    public void randomKeySound()
        {
        List<string> sounds = new List<string>();
        sounds.Add(@"c:\Users\Chris\Downloads\keyok1.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok2.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok3.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok4.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok5.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok6.wav");

        string randomSound = sounds.OrderBy(s => Guid.NewGuid()).First();

        SoundPlayer ranKeySound = new SoundPlayer(randomSound);
        ranKeySound.PlaySync();
        }

    #endregion

    }



