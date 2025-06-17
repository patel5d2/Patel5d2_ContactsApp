# Contact App - Patel5d2 ContactsApp

A cross-platform contacts management application built with .NET MAUI (Multi-platform App UI) that runs on both mobile and desktop platforms.

## 📱 Features

- **Cross-Platform Compatibility**: Runs on Android, iOS, macOS, and Windows
- **Contact Management**: Add, view, edit, and manage your contacts
- **Modern UI**: Clean and intuitive user interface optimized for both mobile and desktop experiences
- **Responsive Design**: Adapts seamlessly between mobile and desktop layouts

## 🖼️ Screenshots & UI Preview

The application provides different layouts optimized for various platforms:

- **Mobile Version**: Touch-friendly interface optimized for smartphones and tablets
- **Desktop Version**: Full-featured interface for Windows and macOS

> **Note**: See the included `AS6 contactlist.pdf` file for detailed UI mockups and design specifications showing how the app appears on both mobile and Windows versions.

## 🛠️ Technology Stack

- **Framework**: .NET MAUI (Multi-platform App UI)
- **Programming Language**: C#
- **UI Framework**: XAML
- **Architecture Pattern**: MVVM (Model-View-ViewModel)
- **Target Platforms**: 
  - Android
  - iOS
  - macOS
  - Windows

## 📁 Project Structure

```
Patel5d2_ContactsApp/
├── Models/                 # Data models and entities
│   └── Contact.cs         # Contact model definition
├── Views/                 # UI views and pages
│   └── ContactDetailsPage.xaml
├── ViewModels/            # View model classes (MVVM pattern)
├── Services/              # Business logic and data services
├── Resources/             # App resources (images, styles, etc.)
├── Platforms/             # Platform-specific implementations
├── Properties/            # App properties and configurations
├── App.xaml              # Application-level resources
├── AppShell.xaml         # Application shell navigation
├── ContactsPage.xaml     # Main contacts listing page
├── MainPage.xaml         # Application main page
└── MauiProgram.cs        # App configuration and startup
```

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2022 (version 17.3 or later) with .NET MAUI workload
- .NET 6.0 or later
- For mobile development:
  - Android SDK (for Android apps)
  - Xcode (for iOS apps, macOS only)

### Installation & Setup

1. **Clone the repository**
   ```bash
   git clone [your-repository-url]
   cd Patel5d2_ContactsApp
   ```

2. **Open the solution**
   - Open `Patel5d2_ContactsApp.sln` in Visual Studio 2022

3. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

4. **Build the solution**
   ```bash
   dotnet build
   ```

5. **Run the application**
   - Select your target platform (Android, iOS, Windows, or macOS)
   - Press F5 or click the Run button in Visual Studio

## 📱 Platform-Specific Features

### Mobile (iOS/Android)
- Touch-optimized navigation
- Swipe gestures for contact management
- Native mobile UI controls
- Optimized for portrait and landscape orientations

### Desktop (Windows/macOS)
- Full keyboard and mouse support
- Resizable windows
- Desktop-native menu systems
- Multi-window support

## 🏗️ Architecture

The application follows the MVVM (Model-View-ViewModel) architectural pattern:

- **Models**: Define the data structure (Contact.cs)
- **Views**: XAML-based user interface pages
- **ViewModels**: Handle business logic and data binding
- **Services**: Manage data persistence and business operations

## 🔧 Configuration

The app can be configured through:
- `MauiProgram.cs`: Dependency injection and service registration
- `App.xaml`: Application-level resources and theming
- `AppShell.xaml`: Navigation structure and routing

## 📝 Development Notes

- The project uses .NET MAUI for cross-platform development
- XAML is used for UI definition with C# code-behind for logic
- The app structure supports easy extension for additional features
- Platform-specific customizations are handled in the `Platforms/` folder

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

### MIT License Summary
- ✅ Commercial use
- ✅ Modification
- ✅ Distribution
- ✅ Private use
- ❌ Liability
- ❌ Warranty
  
## 👨‍💻 Author

**Dharmin Patel**
- Student ID: Patel5d2
- Course: Mobile Development
- Please reference this suppository if you're using any of this work
---

* This project demonstrates cross-platform mobile and desktop application development using .NET MAUI framework.
