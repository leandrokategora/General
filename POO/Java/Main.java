package Java;

import java.sql.Driver;

import javax.transaction.xa.XAResource;

class Main {
    public static void main(String[] args) {
        //System.out.println("hola mundo");        
        Car car = new Car();
        car.license = "AMQ123";
        car.driver = "Andres Herrera";
        car.passenger = 4;
        //System.out.println("Car Licenses: " + car.license);
        car.printDataCar();

        Car car2 = new Car();
        car2.license = "QWE567";
        car2.driver = "Marcos";
        car2.passenger = 3;
        //System.out.println("Car License: " + car2.license);
        car.printDataCar();


        }
    
    }

