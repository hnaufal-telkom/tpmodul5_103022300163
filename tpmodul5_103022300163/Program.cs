// See https://aka.ms/new-console-template for more information

class DataGeneric<T> {
	private T data;

	public DataGeneric(ref T data) {
		this.data = data;
	}
	public void PrintData() {
		Console.WriteLine("Data yang tersimpan adalah: " + data);
	}
}

class Program {
	static void Main(string[] args) {
		long nim = 103022300163;
		DataGeneric<long> dataG = new DataGeneric<long>(ref nim);
		dataG.PrintData();
	}
}
