package Solution;

public class Client {

	public static void main(String[] args) {

		EagerRegistry registry = EagerRegistry.getInstance();
		EagerRegistry registry2 = EagerRegistry.getInstance();
		System.out.println(registry == registry2);

		LazyRegistryWithDCL l1 = LazyRegistryWithDCL.getInstance();
		LazyRegistryWithDCL l2 = LazyRegistryWithDCL.getInstance();
		System.out.println(l1 == l2);

		LazyRegistryIODH singleton;
		singleton = LazyRegistryIODH.getInstance();
	}

}
