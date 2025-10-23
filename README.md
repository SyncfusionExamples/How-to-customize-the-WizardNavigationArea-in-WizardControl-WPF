# Customize the WizardNavigationArea in Syncfusion WPF WizardControl
## Overview 
The WizardControl is a powerful UI component that helps developers create step-by-step navigation interfaces, commonly used in installation wizards, configuration screens, and multi-step forms. This guide shows how to customize the navigation area of the Syncfusion WPF WizardControl. The navigation area typically includes Next, Previous, Finish, and Cancel buttons. Customizing it lets you match your app’s theme, change labels, add buttons (e.g., Help/Skip), and inject validation before navigation.

## Why customize the navigation area?
- Match application branding with custom styles and templates
- Rename or hide default buttons
- Add custom actions (Help, Skip, Export, etc.)
- Implement validation or conditional navigation logic
  
## Prerequisites
- .NET (WPF)
- Syncfusion WPF controls (WizardControl)
- Namespace: Syncfusion.Windows.Tools.Wpf

## Common customization approaches
- Replace the navigation area with a custom template
- Restyle or relabel existing buttons
- Add custom buttons and wire them to commands or events
- Intercept navigation to perform validation
