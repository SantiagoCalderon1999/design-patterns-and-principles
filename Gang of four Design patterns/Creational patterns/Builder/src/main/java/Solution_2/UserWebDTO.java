package Solution_2;

import java.time.LocalDate;
import java.time.Period;

//A product in builder pattern
public class UserWebDTO implements UserDTO {

	private String name;
	
	private String address;
	
	private String age;
	
	public String getName() {
		return name;
	}

	public String getAddress() {
		return address;
	}

	public String getAge() {
		return age;
	}

	private void setName(String name) {
		this.name = name;
	}

	private void setAddress(String address) {
		this.address = address;
	}

	private void setAge(String age) {
		this.age = age;
	}

	@Override
	public String toString() {
		return "name=" + name + "\nage=" + age + "\naddress=" + address ;
	}

	public static UserDTOBuilder getBuilder(){
		return new UserDTOBuilder();
	}
	public static class UserDTOBuilder {

		private String firstName;
		private String lastName;
		private String age;
		private String address;

		private UserWebDTO dto;

		public UserDTOBuilder withFirstName(String fname) {
			firstName = fname;
			return this;
		}

		public UserDTOBuilder withLastName(String lname) {
			lastName = lname;
			return this;
		}

		public UserDTOBuilder withBirthday(LocalDate date) {
			Period ageInYears = Period.between(date, LocalDate.now());
			age = Integer.toString(ageInYears.getYears());
			return this;
		}

		public UserDTOBuilder withAddress(Address address) {
			this.address = address.getHouseNumber() + ", " + address.getStreet()
					+ "\n" + address.getCity() + "\n" + address.getState() + " " +address.getZipcode();
			return this;
		}

		public UserDTO build() {
			this.dto = new UserWebDTO();
			dto.setName(firstName + " " + lastName);
			dto.setAddress(address);
			dto.setAge(age);
			return this.dto;
		}

		public UserDTO getUserDTO() {
			return dto;
		}
	}
	
}
