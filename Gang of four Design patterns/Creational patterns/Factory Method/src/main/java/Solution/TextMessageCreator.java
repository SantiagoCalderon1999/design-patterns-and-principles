package Solution;

import Solution.message.Message;
import Solution.message.TextMessage;

/**
 * Provides implementation for creating Text messages
 */
public class TextMessageCreator extends MessageCreator {


    @Override
    public Message createMessage() {
        return new TextMessage();
    }
}
