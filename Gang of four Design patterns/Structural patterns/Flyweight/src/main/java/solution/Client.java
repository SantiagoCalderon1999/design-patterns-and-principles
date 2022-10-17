package solution;


import problem.UserBannedErrorMessage;

public class Client {

	public static void main(String[] args) {
		SystemErrorMessage msg1 = ErrorMessageFactory.getInstance().getError(ErrorMessageFactory.ErrorType.GenericSystemError);
		System.out.println(msg1.getText("401"));

		UserBannedErrorMessage msg2 = problem.ErrorMessageFactory.getInstance().getUserBannedMessage("1202");
		System.out.println(msg2.getText(null));
	}

}
