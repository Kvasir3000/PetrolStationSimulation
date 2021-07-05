# Petrol Station Simulation
The following project is a university assignment for the programming module on my first year. The program is written in C#, Windows Forms are used as GUI.
## Description 
The task was to create a software, which would simulate the work of a petrol station and record the detailed information about the performance of the company. There are 9 pumps at the station, arranged in a 3 x 3 square, the pump is considered to be available if it is not fueling the vehicle at the moment AND if the neighbour pump to the left is also free, otherwise the pump will be unavailable to vehicles. New vehicles arrive to the station every 1-3.5 seconds, there are three types of vehicles: cars, vans and HGVs, they all differ in possible fuel types and the size of the tanks. 
> Car: Diesel, LPG, Unleaded types of fuel

> Van: Diesel, LPG types of fuel 

> HGV: Diesel type of fuel 

After the vehicle has arrived, it will look for a free pump, if all of the pumps are busy or the way to free pumps is blocked by other machines, the vehilce will stand in the line. As soon as the vehicle finds the free pump it will start fueling up at it, the time for fueling depends on the amount of the required fuel for a particular vehicle. Each of the vehicles has its time limit for waiting in the line, if the vehicle waits for too long, it leaves the station. The information about the left vehicles and served ones will be tracked, if the user wants, he can save this data in a .csv file.  