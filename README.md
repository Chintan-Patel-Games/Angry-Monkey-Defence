# Angry Monkey Game 🐒🎯

**Angry Monkey Game** is a 2D tower defense-style game built in **Unity** (C#), inspired by the Bloons Tower Defense series. Players strategically place monkeys to pop waves of incoming enemies, combining fun gameplay with clean software architecture patterns.

# 🎮 Features
- Fun tower defense mechanics with monkey towers
- Multiple enemy waves with increasing difficulty
- Simple UI for gameplay feedback
- Expandable design using clean architecture principles
  
# 🖥️ 🛠️ Technologies Used
- **Unity (C#)**
- **Unity UI System**
- **ScriptableObjects** for data-driven design

# 🚀 How to Run

## Prerequisites
- Unity 2021.3 or later installed
- Git (optional, for cloning)

## Steps

1. **Clone the repository:**
    ```bash
    git clone https://github.com/Chintan-Patel-Games/Angry-Monkey-Game.git
    ```
2. Open the project in Unity
3. Launch Unity Hub
4. Click "Open" and select the cloned folder
5. Open the main scene and click Play

# 📚 Concepts Demonstrated
- **Singleton** – Ensures core managers (e.g., GameManager, UIManager) have a single instance
- **Generic Singleton** – Reusable base singleton class to reduce code duplication
- **Service Locator Pattern** – Provides global access to game services without tight coupling
- **Dependency Injection** – Loosely connects components, improving scalability and testability
