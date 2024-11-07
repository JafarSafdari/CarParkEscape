# Notes

* ⚠️ **WIP**  
* ✅ **GREEN**  
* 🧠 **In Discovery**  
* ❌ **RED**  
* 📝 **TBD**  

### Goal: 
### Time 🍅
### Notes:

1. You are passed the carpark data as an argument into the function.

2. Free carparking spaces are represented by a 0

3. Staircases are represented by a 1

4. Your parking place (start position) is represented by a 2 which could be on any floor.

5. The exit is always the far right element of the ground floor.

6. You must use the staircases to go down a level.

7. You will never start on a staircase.

8. The start level may be any level of the car park.

9. Each floor will have only one staircase apart from the ground floor which will not have any staircases.

Input as 2d-array of ints -> [[1,0,0,0],[0,0,0,0]]

Return list of directions as strings -> ["L2", "D1", "R4"...]

1. ~~Sätta upp metodsignatur~~
2. ~~Testa metod returnvärde, alltså returnerar en string[]~~
3. Börjar på samma plan som utgång
    * behöver hitta bilens position
    * hitta utgången
    * hitta avståndet mellan bil och utgång
4. Metod för att hitta index av bilen
    * med tester
5. Extrahera "getDirection" metod?
6. Samma plan annat avstånd
7. Bil och utgång på olika plan