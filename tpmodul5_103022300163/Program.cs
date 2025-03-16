// See https://aka.ms/new-console-template for more information

class HaloGeneric {
	public void SapaUser<T>(ref T user) {
		Console.WriteLine("Halo user " + user);
	}
}

class Program {
	static void Main(string[] args) {
		HaloGeneric haloG = new HaloGeneric();
		string user = "hapis";
		haloG.SapaUser<string>(ref user);
	}
}
