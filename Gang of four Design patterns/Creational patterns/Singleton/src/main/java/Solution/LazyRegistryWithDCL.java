package Solution;

/**
 * This class demonstrates singleton pattern using Double Checked Locking or "classic" singleton.
 * This is also a lazy initializing singleton.
 * Although this implementation solves the multi-threading issue with lazy initialization using volatile
 * and double check locking, the volatile keyword is guaranteed to work only after JVMs starting with
 * version 1.5 and later.
 */
public class LazyRegistryWithDCL {

 private LazyRegistryWithDCL(){

 }
 // Volatile forces value read/write from main memory instead of cache
 private static volatile LazyRegistryWithDCL INSTANCE;

 public static  LazyRegistryWithDCL getInstance(){
     // Double check locking (DCL)
     if(INSTANCE == null){
         synchronized (LazyRegistryWithDCL.class){
             if(INSTANCE == null){
                 INSTANCE = new LazyRegistryWithDCL();
             }
         }
     }
     return INSTANCE;
 }
}
