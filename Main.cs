using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;


namespace StarshipRegistryGUI;

public partial class MainForm : Form
    {
    #region Basic Form Functionality
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    readonly Splash Spl;


    public MainForm(Splash spl)
        {
        InitializeComponent();
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // corner rounding
        Spl = spl;


        // BUTTON MOUSE OVER
        StarshipButton.MouseEnter += new EventHandler(StarshipRegButton_MouseEnter);
        StarshipButton.MouseLeave += new EventHandler(StarshipRegButton_MouseLeave);

        StationButton.MouseEnter += new EventHandler(StationRegButton_MouseEnter);
        StationButton.MouseLeave += new EventHandler(StationRegButton_MouseLeave);

        WatchButton.MouseEnter += new EventHandler(WatchButton_MouseEnter);
        WatchButton.MouseLeave += new EventHandler(WatchButton_MouseLeave);

        ExitButton.MouseEnter += new EventHandler(ExitButton_MouseEnter);
        ExitButton.MouseLeave += new EventHandler(ExitButton_MouseLeave);

        ClearButton.MouseEnter += new EventHandler(ClearButton_MouseEnter);
        ClearButton.MouseLeave += new EventHandler(ClearButton_MouseLeave);

        ConfirmButton.MouseEnter += new EventHandler(ConfirmButton_MouseEnter);
        ConfirmButton.MouseLeave += new EventHandler(ConfirmButton_MouseLeave);



        // field visibility at start
        inputText.Visible = false;
        selectionLabel.Visible = false;
        outputLabel.Visible = false;
        PplusLogo.Visible = false;
        WatchOnPPlus.Visible = false;

        }


    public MainForm()
        {
        }

    private void MainForm_Load(object sender, EventArgs e)
        {

        // show screen sound
        SoundPlayer sPlayer = new(Properties.Resources.scrshow);
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
    public void AccessBtn_Click(object sender, EventArgs e)
        {
        StarshipBtnClicked = true;
        statRegClicked = false;

        RandomKeySound();
        StarshipSearchScreen();

        }

    // Call-to-Action and default appearance for Starship Search functionality
    public void StarshipSearchScreen()
        {
        // helper methods
        AlwaysVisible();
        ClearTextFields();
        FocusInput();
        PplusLogo.Visible = false;
        WatchOnPPlus.Visible = false;

        AppTitleLabel.Text = "// DATABASE OF IDENTIFIED STARSHIPS";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "/ STARSHIP REGISTRY";
        selectionLabel.Text = "SEARCH PARAMETERS:";

        outputLabel.Text = "SEARCH INSTRUCTIONS: \n" +
            "ENTER THE SEARCH KEYWORD OF THE VESSEL YOU WISH TO QUERY [EX. 'NCC-1701' OR 'USS ENTERPRISE'] THEN PRESS ENTER OR CLICK 'CONFIRM'. \n\r\n\r" +
            "CONSULT THE LIST OF REGISTERED VESSELS TO THE RIGHT IF YOU NEED ASSISTANCE WITH YOUR SEARCH.";
        }



    // Activates Station Registry method
    public bool statRegClicked = false;
    private void StationRegButton_Click(object sender, EventArgs e)
        {
        StarshipBtnClicked = false;
        statRegClicked = true;

        RandomKeySound(); // plays a random sound when buttons are pressed
        StationSearchScreen();
        }



    public void StationSearchScreen()
        {
        AlwaysVisible();
        ClearTextFields();
        FocusInput();
        PplusLogo.Visible = false;
        WatchOnPPlus.Visible = false;

        AppTitleLabel.Text = "// DATABASE OF PORTS AND STARBASES";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "/ STARBASE DATABASE";
        selectionLabel.Text = "SEARCH PARAMETERS:";

        outputLabel.Text = "SEARCH INSTRUCTIONS: \n" +
                    "ENTER THE NAME OF THE STARBASE YOU WISH TO QUERY [EX. 'DEEP SPACE 9'] THEN PRESS ENTER OR CLICK 'CONFIRM'.\n\r\n\r" +
            "CONSULT THE LIST OF REGISTERED SPACE STATIONS TO THE RIGHT IF YOU NEED ASSISTANCE WITH YOUR SEARCH.";
        }




    // WATCH STAR TREK BUTTON
    private void WatchButton_Click(object sender, EventArgs e)
        {
        // helper methods
        ClearTextFields();

        inputText.Visible = false;
        PplusLogo.Visible = true;
        WatchOnPPlus.Visible = true;
        RegisteredShips.Text = String.Empty;

        RandomKeySound(); // plays a random sound when buttons are pressed
        AppTitleLabel.Text = "// LET'S SEE WHAT'S OUT THERE";

        headingLabel.Font = new Font("Antonio", 28.0f, FontStyle.Regular);
        headingLabel.Text = "/ WHERE TO STREAM THE STAR TREK UNIVERSE";
        selectionLabel.Text = "ENGAGE!";
        outputLabel.Text = "\"You know the greatest danger facing us is ourselves, and irrational fear of the unknown. There is no such thing as the unknown. Only things temporarily hidden, temporarily not understood.\" \n\r\n\r- James T. Kirk // 'The Corbomite Maneuver' Star Trek: The Original Series S1E10";
        }

    private void WatchOnPPlus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        Process.Start(new ProcessStartInfo() { FileName = "www.paramountplus.com", UseShellExecute = true });
        }

    private void PplusLogo_Click(object sender, EventArgs e)
        {
        Process.Start(new ProcessStartInfo() { FileName = "www.paramountplus.com", UseShellExecute = true });
        }

    // EXIT BUTTON
    private void ExitBtn_Click(object sender, EventArgs e)
        {
        // Plays end of session sound
        SoundPlayer sPlayer = new(Properties.Resources.communications_end_transmission);
        sPlayer.PlaySync();

        // Exits the program
        Application.Exit();
        }


    // CONFIRM BUTTON
    public void ConfirmButton_Click(object sender, EventArgs e)
        {
        Focus();
        //ConfirmButton.Enabled = false;

        if (StarshipBtnClicked == true)
            {
            //ConfirmButton.Enabled = true;
            StarshipSearch();
            }
        else if (statRegClicked == true)
            {
            //    ConfirmButton.Enabled = true;
            StationSearch();
            }
        }


    // Clears all text fields and resets UI to default based on which button is active
    private void ClearButton_Click(object sender, EventArgs e)
        {
        if (StarshipBtnClicked == true)
            {
            RandomKeySound();
            StarshipSearchScreen();
            }
        else if (statRegClicked == true)
            {
            RandomKeySound();
            StationSearchScreen();
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

        RegisteredShips.Text = $"REGISTERED STARSHIPS" + "\n\r" +
            "--------------" + "\n\r" +
            "NX-01 | USS ENTERPRISE" + "\n\r" +
                      "NCC-1701 | USS ENTERPRISE" + "\n\r" +
                                "NCC-1701 A | USS ENTERPRISE A" + "\n\r" +
                                 "NCC-1701 D | USS ENTERPRISE D" + "\n\r" +
                                  "NCC-1701 E| USS ENTERPRISE E" + "\n\r" +
                                   "NCC-71807 | USS YAMATO" + "\n\r" +
                                    "NCC-71832 | USS ODYSSEY" + "\n\r" +
                                    "NCC-74656 | USS VOYAGER" + "\n\r" +
                                    "NX-72405 | USS DEFIANT" + "\n\r" +
                                    "NCC-74210 | USS VALIANT" + "\n\r" +
                                    "NCC-1031 | USS DISCOVERY" + "\n\r" +
                                    "NCC-75567 | USS CERRITOS" + "\n\r" +
                                    "NX-76884 | USS PROTOSTAR" + "\n\r" +
                                    "NX-82893 | USS STARGAZER" + "\n\r" +
                                    "NAR-93131 | SS LA SIRENA" + "\n\r" +
                                    "IKC-62127 | IKS ROTARRAN" + "\n\r" +
                                    "SCIMITAR" + "\n\r";



        }



    public void StationSearch()
        {
        Stations ds9 = new("Deep Space 9", "Terok Nor Class", "Bajoran Militia / Starfleet", "Denorios Belt / Bajoran System", "Alpha Quadrant", "300 - 2000 Crew Members", "7000 People", "6 DOCKING PYLONS / 3 MEDIUM DOCKING RING PORTS / 9 SMALL DOCKING RING PORTS / 6 LANDING PADS", "48 PHASER ARRAYS WITH ROTARY MOUNTS / 36 PHASER EMITTERS WITH STATIONARY MOUNTS / 3 PHASER EMITTERS WITH SLIDING MOUNTS / 48+ TORPEDO LAUNCHERS / 5000+ PHOTON TORPEDOES", "Deflector Shields", "ACTIVE");

        Stations utopia = new("Utopia Planitia Shipyards", "Shipyard", "Starfleet", "Sol System / Orbiting Mars", "Alpha Quadrant", "830 crew members", "", "64 space pads / 322 T1 Drydocks / 89 t2 drydocks / 50 t3 drydocks / 25 t4 drydocks / 1 spacedock", "30 defense platforms", "Deflector Shields / Tachyon Detection Grid", "Destroyed 2385");

        string station = inputText.Text.ToUpper();

        outputLabel.Text = station switch
            {

                "DEEP SPACE 9" or "DS9" => $"STATION DESIGNATION: {ds9.stationName.ToUpper()}" + "\n\r" +
                                    $"CLASS: {ds9.stationClass.ToUpper()}" + "\n\r" +
                                    $"OPERATOR: {ds9.stationOperator.ToUpper()}" + "\n\r" +
                                    $"GALACTIC QUADRANT: {ds9.galacticQuadrant.ToUpper()}" + "\n\r" +
                                    $"CREW COMPLIMENT: {ds9.crewCapacity.ToUpper()}" + "\n\r" +
                                    $"MAXIMUM OCCUPANCY: {ds9.maximumOccupant.ToUpper()}" + "\n\r" +
                                    $"DOCKING FACILITIES: {ds9.docking.ToUpper()}" + "\n\r" +
                                    $"WEAPON SYSTEMS: {ds9.weaponCapability.ToUpper()}" + "\n\r" +
                                    $"DEFENSE CAPABILITES: {ds9.defenses.ToUpper()}" + "\n\r" +
                                    $"STATUS: {ds9.status.ToUpper()}" + "\n\r",

                "UTOPIA PLANITIA SHIPYARDS" or "UTOPIA PLANITIA" => $"STATION DESIGNATION: {utopia.stationName.ToUpper()}" + "\n\r" +
                                    $"CLASS: {utopia.stationClass.ToUpper()}" + "\n\r" +
                                    $"OPERATOR: {utopia.stationOperator.ToUpper()}" + "\n\r" +
                                    $"GALACTIC QUADRANT: {utopia.galacticQuadrant.ToUpper()}" + "\n\r" +
                                    $"CREW COMPLIMENT: {utopia.crewCapacity.ToUpper()}" + "\n\r" +
                                    $"MAXIMUM OCCUPANCY: {utopia.maximumOccupant.ToUpper()}" + "\n\r" +
                                    $"DOCKING FACILITIES: {utopia.docking.ToUpper()}" + "\n\r" +
                                    $"WEAPON SYSTEMS: {utopia.weaponCapability.ToUpper()}" + "\n\r" +
                                    $"DEFENSE CAPABILITES: {utopia.defenses.ToUpper()}" + "\n\r" +
                                    $"STATUS: {utopia.status.ToUpper()}" + "\n\r",

                _ => $"SPACE STATION '{station}' WAS NOT FOUND. PLEASE VERIFY SEARCH PARAMETERS AND TRY AGAIN.",
                };

        RegisteredShips.Text = $"REGISTERED SPACE STATIONS" + "\n\r" +
                                "--------------" + "\n\r" +
                                "DEEP SPACE 9" + "\n\r" +
                                 "UTOPIA PLANITIA SHIPYARDS" + "\n\r";
        }

    #endregion





    #region Mouse Over Methods
    // Swaps button images for mouse over
    void StarshipRegButton_MouseEnter(object sender, EventArgs e)   // STARSHIP REGISTRY BUTTON
        {
        this.StarshipButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.starRegOver));
        }

    void StarshipRegButton_MouseLeave(object sender, EventArgs e)
        {
        this.StarshipButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.starRegButton));
        }

    void StationRegButton_MouseEnter(object sender, EventArgs e)     // SPACE STATION REGISTRY BUTTON
        {
        this.StationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.statRegOver));
        }

    void StationRegButton_MouseLeave(object sender, EventArgs e)
        {
        this.StationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.statRegButton));
        }

    void WatchButton_MouseEnter(object sender, EventArgs e)     // WATCH BUTTON
        {
        this.WatchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WatchButtonOver));
        }

    void WatchButton_MouseLeave(object sender, EventArgs e)
        {
        this.WatchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.watchButton));
        }

    void ExitButton_MouseEnter(object sender, EventArgs e)     // EXIT BUTTON
        {
        this.ExitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitOver));
        }

    void ExitButton_MouseLeave(object sender, EventArgs e)
        {
        this.ExitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitButton));
        }
    void ConfirmButton_MouseEnter(object sender, EventArgs e)     // EXIT BUTTON
        {
        this.ConfirmButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ConfirmButtonOver));
        }

    void ConfirmButton_MouseLeave(object sender, EventArgs e)
        {
        this.ConfirmButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ConfirmButton));
        }

    void ClearButton_MouseEnter(object sender, EventArgs e)     // EXIT BUTTON
        {
        this.ClearButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClearButtonOver));
        }

    void ClearButton_MouseLeave(object sender, EventArgs e)
        {
        this.ClearButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClearButton));
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
    public static double CalcStardate()
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
    public static void AcceptedInput()
        {
        SoundPlayer enterPress = new(Properties.Resources.input_ok_2_clean);
        enterPress.PlaySync();
        }

    public static void DeniedInput()
        {
        SoundPlayer enterPress = new(Properties.Resources.input_failed_clean);
        enterPress.Play();
        }


    // PLAYS A RANDOM SOUND WHEN BUTTONS ARE PRESSED
    public static void RandomKeySound()
        {
        List<string> sounds = new List<string>();
        sounds.Add(@"c:\Users\Chris\Downloads\keyok1.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok2.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok3.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok4.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok5.wav");
        sounds.Add(@"c:\Users\Chris\Downloads\keyok6.wav");

        string randomSound = sounds.OrderBy(s => Guid.NewGuid()).First();

        SoundPlayer ranKeySound = new(randomSound);
        ranKeySound.PlaySync();
        }

    }




#endregion

