package Solution;

public class Client {

	public static void main(String[] args) {
		ComplexService service = new ComplexService("Simple null report",new NullStorageService());
		service.generateReport();
		
	}

}
