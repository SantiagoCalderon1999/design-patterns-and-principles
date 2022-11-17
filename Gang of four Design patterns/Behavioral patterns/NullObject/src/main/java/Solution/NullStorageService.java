package Solution;

import java.io.IOException;
import java.io.PrintWriter;

public class NullStorageService extends  StorageService{

    @Override
    public void save(Report report) {
        System.out.println("Null object save method. Doing nothing");
    }
}
