package solution;

public class PrintVisitor implements Visitor{

    @Override
    public void visit(Programmer programmer) {
        String msg = programmer.getName() + " is a " + programmer.getSkill() + " programmer.";
        System.out.println(msg);
    }

    @Override
    public void visit(ProjectLead projectLead) {
        String msg = projectLead.getName() +  " is a project lead with " + projectLead.getDirectReports().size() + " programmers reporting.";
        System.out.println(msg);
    }

    @Override
    public void visit(Manager manager) {
        String msg = manager.getName() + " is a manager with " + manager.getDirectReports().size() + " leads reporting";
        System.out.println(msg);
    }

    @Override
    public void visit(VicePresident vicePresident) {
        String msg = vicePresident.getName()+ " is the vp";
        System.out.println(msg);
    }
}
