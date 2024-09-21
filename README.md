# CloudAnalytic

CloudAnalytic is a free and open-source web application built using Blazor on .NET 8.0. It tracks user activity on websites and apps while respecting user privacy. CloudAnalytic anonymizes and hashes personal data like IP addresses and device information to generate pseudo "users" with randomized names such as "John Doe." It provides insight into user navigation, page visits, and conversion actions like purchases.

## Features

- **User Anonymization**: Personal details such as IP and device information are hashed and randomized to protect user privacy.
- **Randomized User Names**: Each user is assigned a randomized alias like "John Doe" for tracking purposes.
- **Track User Activity**: Get detailed insights into which pages users visit, how they navigate, and whether they complete key actions like purchases.
- **Event Tracking**: Capture specific user actions such as clicks, page views, and purchases.
- **Open Source**: Free to use, modify, and contribute under the AGPL 3.0 license.

## Installation

### Windows

1. Install [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0):
   - Download and install the .NET 8.0 SDK from the official website.
   - Make sure to set up the environment variables correctly.

2. Clone the repository:
   ```bash
   git clone https://github.com/your-username/CloudAnalytic.git
   cd CloudAnalytic
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

6. Open your browser and navigate to `http://localhost:5000`.

### Linux

1. Install .NET 8.0 SDK:

   For Ubuntu or other Debian-based systems:
   ```bash
   sudo apt-get update
   sudo apt-get install -y dotnet-sdk-8.0
   ```

   For Fedora-based systems:
   ```bash
   sudo dnf install dotnet-sdk-8.0
   ```

2. Clone the repository:
   ```bash
   git clone https://github.com/your-username/CloudAnalytic.git
   cd CloudAnalytic
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

6. Open your browser and navigate to `http://localhost:5000`.

## Usage

1. **Analyzing User Behavior**:  
   Access the CloudAnalytic dashboard to view pseudo users, track their page visits, and see whether they completed any conversion actions like purchases.
   
## Premium Support

We offer **Premium Support** for $30/month, which includes:

- **Installation Support**: Help with setting up CloudAnalytic on your Windows or Linux server/VPS.
- **Direct Issue Support**: Priority assistance for any issues that arise with the application.
- **Feature Requests**: Request new features or enhancements, and we’ll work with you to implement them.

If you're interested in premium support, feel free to reach out to us at [info@viov.nl].

## Contributing

We welcome contributions! Feel free to fork the repository, create a branch, and submit a pull request. You can also open an issue for bug reports or feature suggestions.

## License

CloudAnalytic is licensed under the [AGPL 3.0 License](LICENSE).
