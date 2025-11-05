using System.Text.RegularExpressions;

namespace EstacionamientoAutos;

public partial class Form1 : Form
{
    private CircularDoublyLinkedList parkingLot;
    private List<Car> departedCars;

    public Form1()
    {
        InitializeComponent();
        parkingLot = new CircularDoublyLinkedList();
        departedCars = new List<Car>();
    }

    private void btnRegisterEntry_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPlate.Text) || string.IsNullOrWhiteSpace(txtOwner.Text))
        {
            MessageBox.Show("Por favor, ingrese la placa y el propietario del vehículo.");
            return;
        }

        string plate = txtPlate.Text.ToUpper();
        Regex plateRegex = new Regex("^[A-Z]{3}[0-9]{3}$");

        if (!plateRegex.IsMatch(plate))
        {
            MessageBox.Show("Formato de placa inválido. Debe ser 3 letras seguidas de 3 números (ej. ABC123).");
            return;
        }

        string owner = txtOwner.Text;
        Regex ownerRegex = new Regex("^[a-zA-Z ]+$");

        if (!ownerRegex.IsMatch(owner))
        {
            MessageBox.Show("El nombre del propietario solo puede contener letras y espacios.");
            return;
        }

        Car newCar = new Car(plate, owner);
        parkingLot.Enqueue(newCar);

        txtPlate.Clear();
        txtOwner.Clear();

        UpdateCarList();

        MessageBox.Show("Vehículo registrado con éxito.");
    }

    private void btnRegisterExit_Click(object sender, EventArgs e)
    {
        if (parkingLot.Count() == 0)
        {
            MessageBox.Show("El estacionamiento está vacío.");
            return;
        }

        Car? exitingCar = parkingLot.Dequeue();

        if (exitingCar != null)
        {
            DateTime exitTime = DateTime.Now;
            TimeSpan timeSpent = exitTime - exitingCar.EntryTime;
            double cost = timeSpent.TotalSeconds * 2.0;

            lblCost.Text = $"Costo: ${cost:F2}";

            departedCars.Add(exitingCar);
            UpdateCarList();
            UpdateDepartedCarList();

            MessageBox.Show("Vehículo ha salido del estacionamiento.");
        }
    }

    private void UpdateCarList()
    {
        lstCars.Items.Clear();
        foreach (Car car in parkingLot.ToArray())
        {
            lstCars.Items.Add(car.ToString());
        }
    }

    private void UpdateDepartedCarList()
    {
        lstDepartedCars.Items.Clear();
        foreach (Car car in departedCars)
        {
            lstDepartedCars.Items.Add(car.ToString());
        }
    }
}
