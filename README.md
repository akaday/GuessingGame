# GuessingGame

## Overview
**GuessingGame** is a simple and fun console application built with C#. The game generates a random number between 1 and 100, and the player has to guess the number. The game provides feedback if the guess is too high or too low and tracks the number of guesses.

## Features
- Random number generation
- User input for guessing the number
- Feedback on guesses (too high, too low, correct)
- Tracks the number of guesses
- Difficulty levels (Easy, Medium, Hard)
- High score tracker
- Limited number of guesses based on difficulty level

## How to Play
1. The game will generate a random number between 1 and 100.
2. You will be prompted to select a difficulty level:
   - Easy (10 guesses)
   - Medium (7 guesses)
   - Hard (5 guesses)
3. You will be prompted to enter your guess.
4. The game will provide feedback:
   - "Too high! Try again." if the guess is greater than the number.
   - "Too low! Try again." if the guess is less than the number.
   - "Congratulations! You guessed the number in X tries." if the guess is correct.
5. The game will track and display the high score.

## Setup and Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/akaday/GuessingGame.git
   cd GuessingGame
   ```
2. **Build the Project**:
   ```bash
   dotnet build
   ```
3. **Run the Application**:
   ```bash
   dotnet run
   ```

## Contributing
1. **Fork the Repository**.
2. **Create a Branch**:
   ```bash
   git checkout -b feature-branch
   ```
3. **Commit Your Changes**:
   ```bash
   git commit -am 'Add new feature'
   ```
4. **Push to the Branch**:
   ```bash
   git push origin feature-branch
   ```
5. **Create a Pull Request**.

## License
This project is licensed under the MIT License.

Enjoy playing the GuessingGame and feel free to contribute to make it even more exciting! 🚀✨

Feel free to customize this `README.md` further based on any additional features or details you'd like to include. 

If you have any other ideas or need further assistance, just let me know! 😊📘✨
