package class8;

public class Mainclass {
    public static void main(String[] args){
        try{

            UserManagement userManagement = new UserManagement();
            User user = userManagement.createUser();

            user.display();

        } catch (RuntimeException e){
            System.out.println(e.getMessage());
        }
    }
}
