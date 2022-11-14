using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;


namespace StarshipRegistryGUI;

public partial class mainForm : Form
    {
    #region Basic Form Functionality
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

        WatchButton.MouseEnter += new EventHandler(watchButton_MouseEnter);
        WatchButton.MouseLeave += new EventHandler(watchButton_MouseLeave);

        exitButton.MouseEnter += new EventHandler(exitButton_MouseEnter);
        exitButton.MouseLeave += new EventHandler(exitButton_MouseLeave);

        // field visibility at start
        inputText.Visible = false;
        selectionLabel.Visible = false;
        outputLabel.Visible = false;
        PplusLogo.Visible = false;
        WatchOnPPlus.Visible = false;

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

        this.AppTitleLabel.Text = "// DATABASE CONNECTED";
        this.headingLabel.Text = "/ WELCOME CAPTAIN " + Spl.splNameInput.Text;

        infoTextBox.Visible = true;
        outputLabel.Visible = true;
        infoTextBox.Text = "UNITED FEDERATION OF PLANETS • UTOPIA PLANITIA SHIPYARDS • MARS • SOL SYSTEM • STARDATE: " + CalcStardate();
        outputLabel.Text = "THIS IS THE STARFLEET DATABASE OF KNOWN STARSHIPS AND SPACE STATIONS.\r\n\r\n" +
            "NAVIGATE THIS SYSTEM USING THE BUTTONS TO THE RIGHT.\r\n\r\n" +
            "THIS SYSTEM WILL ALLOW YOU TO VIEW THE STARSHIPS AND SPACE STATIONS THAT ARE CURRENTLY ENTERED INTO THE DATABASE.\r\n\r\n" +
            "BE ADVISED, THAT THIS DATABASE IS STILL UNDER CONSTRUCTION, SO NOT EVERY VESSEL OR STATION IS AVAILABLE IN THIS REGISTRY.\r\n\r\n" +
            "YOU CAN ADD TO THIS REGISTRY MANUALLY BY USING THE 'NEW REGISTRATION' BUTTON TO THE RIGHT.\r\n\r\n";
        stardateLabel.Text = "" + CalcStardate();
        }

    #endregion




    #region Primary Navigation
    // Activates Starship Registry button and accesses StarshipSearch function (in Confirm Button Method)
    public bool StarshipBtnClicked = false;
    public void accessBtn_Click(object sender, EventArgs e)
        {
        StarshipBtnClicked = true;
        statRegClicked = false;

        randomKeySound();
        StarshipButton();

        }

    // Call-to-Action and default appearance for Starship Search functionality
    public void StarshipButton()
        {
        // helper methods
        AlwaysVisible();
        ClearTextFields();
        FocusInput();

        AppTitleLabel.Text = "// DATABASE OF IDENTIFIED STARSHIPS";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "/ STARSHIP REGISTRY";
        selectionLabel.Text = "SEARCH PARAMETERS:";

        outputLabel.Text = "SEARCH INSTRUCTIONS: \n" +
            "ENTER THE SEARCH KEYWORD OF THE VESSEL YOU WISH TO QUERY [EX. 'NCC-1701' OR 'USS ENTERPRISE'] THEN PRESS ENTER OR CLICK 'CONFIRM'.";
        }

    // Activates Station Registry method
    public bool statRegClicked = false;
    private void stationRegButton_Click(object sender, EventArgs e)
        {
        StarshipBtnClicked = false;
        statRegClicked = true;

        randomKeySound(); // plays a random sound when buttons are pressed
        StationButton();

        }

    public void StationButton()
        {
        AlwaysVisible();
        ClearTextFields();
        FocusInput();

        AppTitleLabel.Text = "// DATABASE OF PORTS AND STARBASES";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "/ STARBASE DATABASE";
        selectionLabel.Text = "SEARCH PARAMETERS:";

        outputLabel.Text = "SEARCH INSTRUCTIONS: \n" +
                    "ENTER THE NAME OF THE STARBASE YOU WISH TO QUERY [EX. 'DEEP SPACE 9'] THEN PRESS ENTER OR CLICK 'CONFIRM'.";
        }


    // WATCH STAR TREK BUTTON
    private void WatchButton_Click(object sender, EventArgs e)
        {
        // helper methods
        ClearTextFields();

        inputText.Visible = false;
        PplusLogo.Visible = true;
        WatchOnPPlus.Visible = true;

        randomKeySound(); // plays a random sound when buttons are pressed
        AppTitleLabel.Text = "// LET'S SEE WHAT'S OUT THERE";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "/ WHERE TO STREAM THE STAR TREK UNIVERSE";
        selectionLabel.Text = String.Empty;
        outputLabel.Text = "\"You know the greatest danger facing us is ourselves, and irrational fear of the unknown. There is no such thing as the unknown. Only things temporarily hidden, temporarily not understood.\" \n\r                                                           - James T. Kirk // 'The Corbomite Maneuver' Star Trek: The Original Series S1E10";
        }

    // Exit button functionality
    private void exitBtn_Click(object sender, EventArgs e)
        {
        // Plays end of session sound
        SoundPlayer sPlayer = new SoundPlayer(@"c:\users\Chris\Downloads\communications_end_transmission.wav");
        sPlayer.PlaySync();

        // Exits the program
        Application.Exit();
        }


    // Confirm button logic that calls appropriate methods based on which button is active
    public void confirmButton_Click(object sender, EventArgs e)
        {
        Focus();
        confirmButton.Enabled = false;

        if (StarshipBtnClicked == true)
            {
            confirmButton.Enabled = true;
            StarshipSearch();
            }
        else if (statRegClicked == true)
            {
            confirmButton.Enabled = true;
            }
        }


    // Clears all text fields and resets UI to default based on which button is active
    private void clearButton_Click(object sender, EventArgs e)
        {
        if (StarshipBtnClicked == true)
            {
            randomKeySound();
            StarshipButton();
            }
        else if (statRegClicked == true)
            {
            randomKeySound();
            StationButton();
            }
        }
    #endregion





    #region Features Methods
    // STARSHIP SEARCH METHOD
    public void StarshipSearch()
        {
        var numOfShips = 1;
        for (int sh = 0; sh < numOfShips; sh++)
            {
            var findShip = inputText.Text.ToUpper();

            string[] csvLines = System.IO.File.ReadAllLines(@"starships.csv");

            var ships = new List<Starships>();

            for (int i = 1; i < csvLines.Length; i++)
                {
                Starships ship = new Starships(csvLines[i]);
                ships.Add(ship);
                }
            for (int i = 0; i < ships.Count; i++)
                {
                var searchResult = ships.Where(s => s.ShipName.Contains(findShip) || s.registryNum.Contains(findShip)).FirstOrDefault();
                outputLabel.Text = searchResult.ToString();
                }
            }
        }



    public void StationSearch()
        {
        var numOfStat = 1;
        for (int st = 0; st < numOfStat; st++)
            {
            var findStation = inputText.Text.ToUpper();

            string[] csvLinesSt = System.IO.File.ReadAllLines(@"spacestations.csv");

            var station = new List<Stations>();

            for (int s = 1; s < csvLinesSt.Length; s++)
                {
                Stations spacestation = new Stations(csvLinesSt[s]);
                station.Add(spacestation);
                }

            for (int s = 0; s < station.Count; s++)
                {
                var statResult = station.Where(s => s.stationName.Contains(findStation)).FirstOrDefault();
                outputLabel.Text = statResult.ToString();
                }
            }
        }




    #endregion





    #region Mouse Over Methods
    // Swaps button images for mouse over
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

    void watchButton_MouseEnter(object sender, EventArgs e)     // NEW REGISTRY BUTTON
        {
        this.WatchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WatchButtonOver));
        }

    void watchButton_MouseLeave(object sender, EventArgs e)
        {
        this.WatchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.watchButton));
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




    #region Support Methods

    // Clear text fields
    private void ClearTextFields()
        {
        headingLabel.Text = String.Empty;
        inputText.Text = String.Empty;
        selectionLabel.Text = String.Empty;
        outputLabel.Text = String.Empty;
        }


    // Focuses on inputText box
    private void FocusInput()
        {
        this.inputText.Focus();
        }


    // SETS VISIBILITY OF TEXT FIELDS ON ACCESS & REGISTER SCREENS
    private void AlwaysVisible()
        {
        AppTitleLabel.Visible = true;
        headingLabel.Visible = true;
        inputText.Visible = true;
        selectionLabel.Visible = true;
        outputLabel.Visible = true;
        }


    // Converts current date/time to Stardate
    public double CalcStardate()
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



    // Plays sound effects for Accepted/Denied Inputs
    public void AcceptedInput()
        {
        SoundPlayer enterPress = new SoundPlayer(@"G:\Code Kentucky Projects\StarshipRegistryGUI\Resources\input_ok_2_clean.wav");
        enterPress.PlaySync();
        }

    public void DeniedInput()
        {
        SoundPlayer enterPress = new SoundPlayer(@"G:\Code Kentucky Projects\StarshipRegistryGUI\Resources\input_failed_clean.wav");
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

    private void WatchOnPPlus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        Process.Start(new ProcessStartInfo() { FileName = "www.paramountplus.com", UseShellExecute = true });
        }

    private void PplusLogo_Click(object sender, EventArgs e)
        {
        Process.Start(new ProcessStartInfo() { FileName = "www.paramountplus.com", UseShellExecute = true });
        }
    }




#endregion

