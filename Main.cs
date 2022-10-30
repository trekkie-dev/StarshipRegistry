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

    public mainForm(Splash spl)
        {
        InitializeComponent();
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // corner rounding
        Spl = spl;


        // BUTTON MOUSE OVER
        starshipRegButton.MouseEnter += new EventHandler(starshipRegButton_MouseEnter);
        starshipRegButton.MouseLeave += new EventHandler(starshipRegButton_MouseLeave);

        stationRegButton.MouseEnter += new EventHandler(stationRegButton_MouseEnter);
        stationRegButton.MouseLeave += new EventHandler(stationRegButton_MouseLeave);

        newRegButton.MouseEnter += new EventHandler(newRegButton_MouseEnter);
        newRegButton.MouseLeave += new EventHandler(newRegButton_MouseLeave);

        exitButton.MouseEnter += new EventHandler(exitButton_MouseEnter);
        exitButton.MouseLeave += new EventHandler(exitButton_MouseLeave);



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


        this.headingLabel.Text = "// WELCOME CAPTAIN " + Spl.splNameInput.Text;
        this.appTitleLabel.Text = "LCARS • DATABASE CONNECTED";

        infoTextBox.Visible = true;
        outputTextBox.Visible = true;
        infoTextBox.Text = "UNITED FEDERATION OF PLANETS • UTOPIA PLANITIA SHIPYARDS • MARS • SOL SYSTEM • STARDATE: " + calculateStardate();
        outputTextBox.Text = "THIS IS THE STARFLEET DATABASE OF KNOWN STARSHIPS AND SPACE STATIONS.\r\n\r\nNAVIGATE THIS SYSTEM USING THE BUTTONS TO THE RIGHT.\r\n\r\nTHIS SYSTEM WILL ALLOW YOU TO VIEW THE STARSHIPS AND SPACE STATIONS THAT ARE CURRENTLY ENTERED INTO THE DATABASE.\r\n\r\nBE ADVISED, THAT THIS DATABASE IS STILL UNDER CONSTRUCTION, SO NOT EVERY VESSEL OR STATION IS AVAILABLE IN THIS REGISTRY.\r\n\r\nYOU CAN ADD TO THIS REGISTRY MANUALLY BY USING THE 'NEW REGISTRATION' BUTTON TO THE RIGHT.\r\n\r\n";
        stardateLabel.Text = "" + calculateStardate();
        }

    #endregion





    #region Main Navigation
    private bool regBtnClicked = false;
    public void accessBtn_Click(object sender, EventArgs e)
        {
        regBtnClicked = true;


        // helper methods
        primeElementVisibility();
        homeScreenElementVisibility();
        clearAllTextFields();
        focusOnInput();

        randomKeySound(); // plays a random sound when buttons are pressed

        this.appTitleLabel.Text = "LCARS • DATABASE OF IDENTIFIED STARSHIPS";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "// STARSHIP REGISTRY";
        selectionLabel.Text = "SEARCH PARAMETERS:";
        }

    private bool statRegClicked = false;
    private void stationRegButton_Click(object sender, EventArgs e)
        {
        regBtnClicked = false;
        statRegClicked = true;

        // helper methods
        primeElementVisibility();
        homeScreenElementVisibility();
        clearAllTextFields();
        focusOnInput();

        randomKeySound(); // plays a random sound when buttons are pressed
        appTitleLabel.Text = "LCARS • SPACE STATION REGISTRY";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "// SPACE STATION DATABASE";
        selectionLabel.Text = "SEARCH PARAMETERS:";
        }


    private void newRegButton_Click(object sender, EventArgs e)
        {
        // helper methods
        primeElementVisibility();
        homeScreenElementVisibility();
        clearAllTextFields();
        focusOnInput();

        randomKeySound(); // plays a random sound when buttons are pressed
        appTitleLabel.Text = "LCARS • SPACE STATION REGISTRY";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "// REGISTER NEW STARSHIP OR SPACE STATION";
        selectionLabel.Text = "STARSHIP NAME:";
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

        if (regBtnClicked == true)
            {
            //StarshipSearch();

            }
        else if (statRegClicked == true)
            {
            StationSearch();
            }
        }


    private void clearButton_Click(object sender, EventArgs e)
        {
        randomKeySound(); // plays a random sound when buttons are pressed

        inputText.Clear();
        outputTextBox.Clear();
        focusOnInput();
        }
    #endregion





    #region Features Methods
    // STARSHIP SEARCH METHOD
    public void StarshipSearch()
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
            }
        }


    public void StationSearch()
        {
        string tstText = inputText.Text.ToUpper();

        if (tstText == "WORKING?")
            {
            string filePath = @"G:\Code Kentucky Projects\StarshipRegistryGUI\Resources\text.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
                {
                outputTextBox.Text = line;
                }
            }
        }

    public void NewRegistration()
        {

        }



    #endregion



    #region MOUSE OVER METHODS
    // CHANGES THE BUTTON IMAGE ON MOUSE OVER
    void starshipRegButton_MouseEnter(object sender, EventArgs e)   // STARSHIP REGISTRY BUTTON
        {
        this.starshipRegButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.starRegOver));
        }

    void starshipRegButton_MouseLeave(object sender, EventArgs e)
        {
        this.starshipRegButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.starRegButton));
        }

    void stationRegButton_MouseEnter(object sender, EventArgs e)     // SPACE STATION REGISTRY BUTTON
        {
        this.stationRegButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.statRegOver));
        }

    void stationRegButton_MouseLeave(object sender, EventArgs e)
        {
        this.stationRegButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.statRegButton));
        }

    void newRegButton_MouseEnter(object sender, EventArgs e)     // NEW REGISTRY BUTTON
        {
        this.newRegButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.newRegOver));
        }

    void newRegButton_MouseLeave(object sender, EventArgs e)
        {
        this.newRegButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.newRegButton));
        }

    void exitButton_MouseEnter(object sender, EventArgs e)     // EXIT BUTTON
        {
        this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitOver));
        }

    void exitButton_MouseLeave(object sender, EventArgs e)
        {
        this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitButton));
        }

    #endregion



    // REUSABLE METHODS
    #region Support Methods

    // CLEARS ALL TEXT FIELDS
    private void clearAllTextFields()
        {
        headingLabel.Text = String.Empty;
        inputText.Text = String.Empty;
        selectionLabel.Text = String.Empty;
        outputTextBox.Text = String.Empty;
        }


    // FOCUSES CURSOR ON MAIN TEXT INPUT
    private void focusOnInput()
        {
        this.inputText.Focus();
        }


    // SETS VISIBILITY OF TEXT FIELDS ON ACCESS & REGISTER SCREENS
    private void primeElementVisibility()
        {
        inputText.Visible = true;
        //headingLabel.Visible = true;
        selectionLabel.Visible = true;
        outputTextBox.Visible = true;
        }

    private void homeScreenElementVisibility()
        {


        }



    // CONVERTS DATE INTO STARDATE
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


    // PLAYS SOUND FOR ACCEPTED INPUT
    public void acceptedInput()
        {
        SoundPlayer enterPress = new SoundPlayer(@"c:\users\Chris\Downloads\input_ok_2_clean.wav");
        enterPress.Play();
        }


    // PLAYS A RANDOM SOUND WHEN BUTTONS ARE PRESSED
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


