package Solution;

import javafx.geometry.Point3D;

public class Client {

	public static void main(String[] args) throws CloneNotSupportedException {
        Swordsman sm1 = new Swordsman();
		sm1.move(new Point3D(-10,0,0), 20);
		sm1.attack();

		System.out.println(sm1);

		Swordsman sm2 = (Swordsman)sm1.clone();
		System.out.println("Cloned object " + sm2);
	}

}
