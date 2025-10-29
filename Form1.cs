namespace EstacionamientoAutos;

public partial class Form1 : Form
{
    private CircularDoublyLinkedList parkingLot;

    public Form1()
    {
        InitializeComponent();
        parkingLot = new CircularDoublyLinkedList();
    }

    private void btnRegisterEntry_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPlate.Text) || string.IsNullOrWhiteSpace(txtOwner.Text))
        {
            MessageBox.Show("Por favor, ingrese la placa y el propietario del vehículo.");
            return;
        }

        Car newCar = new Car(txtPlate.Text, txtOwner.Text);
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

            lblCarInfo.Text = $"Vehículo que sale: {exitingCar.Plate}, Propietario: {exitingCar.Owner}, Hora de Entrada: {exitingCar.EntryTime}, Hora de Salida: {exitTime}";
            lblCost.Text = $"Costo: ${cost:F2}";

            UpdateCarList();

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
}
