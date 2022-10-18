package solution;

//Concrete observer
public class PriceObserver implements  OrderObserver{

    @Override
    public void updated(Order order) {
        double total = order.getItemCost();
        if(total >= 500){
            order.setDiscount(20);
        }
        if(total >= 200){
            // discount
            order.setDiscount(10);
        }
    }
}
