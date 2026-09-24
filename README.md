# SentimentWebApp

An ASP.NET Core MVC application that serves ML.NET sentiment predictions through a browser interface.

## Overview

An ASP.NET Core MVC application that serves ML.NET sentiment predictions through a browser interface. The description and capabilities in this document are limited to behavior that can be verified in the repository source.

## Key Features

- Text input and sentiment prediction flow
- ML.NET model loading and inference
- Typed request/result models
- Razor-based prediction interface

## Tech Stack

- C#
- ASP.NET Core MVC
- ML.NET

## Architecture

The application uses ASP.NET Core MVC: controllers receive prediction input, invoke ML.NET inference, and render typed Razor views.

## Project Structure

- `Controllers/` — web and prediction actions
- `Models/` — prediction input/output types
- `Views/` — Razor UI
- `wwwroot/models/` — model artifact

## AI / ML Integration

The repository contains ML.NET inference. It does not provide a comprehensive experiment-tracking or model-evaluation pipeline.

## Getting Started

Run the commands appropriate to the project root:

```bash
dotnet restore
dotnet run
```

## Technical Highlights

- ML inference embedded in an MVC request flow
- Typed prediction inputs and outputs
- Local model artifact loading

## Possible Improvements

- Add or expand automated tests around core workflows.
- Document deployment and environment-specific configuration.
- Add CI checks for build, linting, and tests where they are not already present.
