package solution;

import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.IOException;

public class UserMapper {

    public User mapJsonToUser(String userJson) throws IOException {
        ObjectMapper mapper = new ObjectMapper();
        return mapper.readValue(userJson, User.class);
    }
}
