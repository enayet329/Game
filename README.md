# rock-paper-scissors-console
.NET Command-Line Game with HMAC
This project implements a command-line game in .NET where the computer and the user make moves, ensuring fairness through HMAC (Hash-based Message Authentication Code).

Overview
The game operates as follows:

The computer generates a move.
HMAC is calculated using a generated key to ensure the computer cannot change its move after seeing the user's move.
The user selects their move.
The winner is determined based on the game rules.
Features
Key Generation and HMAC Calculation: Cryptographically strong key generation and HMAC calculation to maintain game fairness.
Game Rules: Determination of the winner based on moves.
Help Table: ASCII-graphic table showing which move wins against which.
User Interaction: Menu options for users to make a move, get help, or exit the game.
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/enayet32/game.git
cd game
Build the project using .NET CLI:

bash
Copy code
dotnet build
Usage
To start the game, navigate to the project directory and run:

bash
Copy code
dotnet run
Follow the prompts to play the game:

Choose your move.
See the computer's move and the result.
Verify the HMAC for fairness.
Help Table
Run the game and choose the help option to see which moves win against others.

Contributing
Contributions are welcome! Please fork the repository and submit a pull request.

License
This project is licensed under the MIT License.
