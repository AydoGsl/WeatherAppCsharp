<h1>Weather App using Csharp</h1>

I got some Challange questions from my course that i will answer using my code.

Question 1: How will you structure your weather data using a class or struct in C#?

Answer:
I used a class called Weather to represent the weather data. This class includes the following properties:

Temperature: An integer representing the temperature in degrees Celsius.
Condition: A string to store the weather condition, such as "Clear," "Rain," or "Snow."
Cloudiness: An integer representing the percentage of cloudiness (0% to 100%).


Question 2: How can you ensure the weather values are randomized every time the program runs?

Answer:
I used the Random class to generate random values for each weather property:

Temperature: A random integer between -10°C and 40°C.
Condition: A random selection from an array of predefined conditions: {"Clear", "Rain", "Snow"}.
Cloudiness: A random integer between 0% and 100%.
Additionally, I ensured that if the condition is "Snow", the temperature is restricted to a realistic range between -10°C and 5°C to maintain realism.


Question 3: How will you implement the warning for extreme weather conditions?

Answer:
The warning is implemented in the Main() method. After generating the random weather data, I check for extreme conditions:

If the weather condition is "Snow" and the temperature is below -10°C, a warning message is displayed.
To make the warning more noticeable, I used Console.ForegroundColor to change the text color to red. After displaying the message, I reset the color using Console.ResetColor().


