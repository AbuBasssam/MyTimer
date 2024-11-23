# Windows Forms Timer Application

This is a simple Windows Forms Timer Application with the following features:
- A **default timer** with a predefined countdown functionality.
- Ability to **dynamically add timers** with user-defined settings.
- **Timer settings persistence** using `app.config`, so timer configurations are saved between application runs.

## Features
1. **Default Timer**:
   - Preconfigured timer with a countdown (default: 60 seconds).
   - Start/Stop button to control the timer.
   - Countdown display on the form.

2. **Dynamic Timers**:
   - Add multiple timers dynamically using the "Add Timer" button.
   - Each dynamic timer includes:
     - A label to display the countdown.
     - A `NumericUpDown` control to set the timer duration (1–60 seconds).
     - A Start/Stop button to toggle the timer.

3. **Settings Persistence**:
   - Timer settings are saved in `app.config` and loaded when the application starts.
   - Default timer duration and all dynamic timers' durations are stored.




