import tkinter as tk

# Create a new window
window = tk.Tk()

# Set the window title
window.title("My Window")

# Set the window size
window.geometry("400x300")

# Create a button
button = tk.Button(window, text="Click Me")

# Add the button to the window
button.pack()

# Function to be executed when the button is clicked
def button_click():
    print("Button clicked!")

# Configure the button to call the button_click function when clicked
button.config(command=button_click)

# Run the window's event loop
window.mainloop()