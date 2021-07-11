# magnet-winforms
A .NET sticky forms control that actually works

### Features
* Edge-to-edge and edge-to-corner magnets
* Joint move and resize of child from when main form moves or resizes
* Simple and clean (Single .cs file) implementation  

### Usage

Simply include MagnetWinForms.cs in your project and create an instance in the form constructor, ie:

    public Form()
    {
    	InitializeComponent();
	
		m_MagnetWinForms = new MagnetWinForms(this);
	}

**NOTE:** All application forms need to create a MagnetWinForms instance. It is, however, important that the main form will be the first to do so.

