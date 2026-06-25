
@import "tailwindcss";
@import "tw-animate-css";

@custom-variant dark (&:is(.dark *));

:root {
  /* Light Theme */

  --background: #f4f7fb;
  --foreground: #0f172a;

  --card: #ffffff;
  --card-foreground: #0f172a;

  --popover: #ffffff;
  --popover-foreground: #0f172a;

  --primary: #2d8cff;
  --primary-foreground: #ffffff;

  --secondary: #e8f1ff;
  --secondary-foreground: #1e3a8a;

  --muted: #eef2f7;
  --muted-foreground: #64748b;

  --accent: #dbeafe;
  --accent-foreground: #1e40af;

  --destructive: #ef4444;
  --destructive-foreground: #ffffff;

  --border: #d9e2ec;
  --input: #e5edf5;
  --ring: #2d8cff;

  --chart-1: #2d8cff;
  --chart-2: #60a5fa;
  --chart-3: #38bdf8;
  --chart-4: #06b6d4;
  --chart-5: #0ea5e9;

  --sidebar: #ffffff;
  --sidebar-foreground: #0f172a;
  --sidebar-primary: #2d8cff;
  --sidebar-primary-foreground: #ffffff;
  --sidebar-accent: #f1f5f9;
  --sidebar-accent-foreground: #0f172a;
  --sidebar-border: #e2e8f0;
  --sidebar-ring: #2d8cff;

  --radius: 1rem;

  --font-sans:
    Inter, ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont,
    "Segoe UI", sans-serif;

  --font-serif:
    ui-serif, Georgia, Cambria, "Times New Roman", serif;

  --font-mono:
    ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas,
    "Liberation Mono", monospace;

  --shadow-2xs: 0 1px 2px rgb(15 23 42 / 0.04);
  --shadow-xs: 0 1px 3px rgb(15 23 42 / 0.05);
  --shadow-sm: 0 4px 12px rgb(15 23 42 / 0.06);
  --shadow: 0 6px 18px rgb(15 23 42 / 0.08);
  --shadow-md: 0 10px 25px rgb(15 23 42 / 0.10);
  --shadow-lg: 0 15px 35px rgb(15 23 42 / 0.12);
  --shadow-xl: 0 20px 45px rgb(15 23 42 / 0.15);
  --shadow-2xl: 0 25px 60px rgb(15 23 42 / 0.20);

  --tracking-normal: 0em;
  --spacing: 0.25rem;
}

.dark {
  /* Dashboard Theme Inspired By Screenshot */

  --background: #171b2a;
  --foreground: #f8fafc;

  --card: #1f2436;
  --card-foreground: #f8fafc;

  --popover: #1f2436;
  --popover-foreground: #f8fafc;

  --primary: #2d8cff;
  --primary-foreground: #ffffff;

  --secondary: #262c40;
  --secondary-foreground: #e2e8f0;

  --muted: #24293d;
  --muted-foreground: #94a3b8;

  --accent: #2b3249;
  --accent-foreground: #f8fafc;

  --destructive: #7f1d1d;
  --destructive-foreground: #ffffff;

  --border: #31384d;
  --input: #2a3148;
  --ring: #2d8cff;

  --chart-1: #2d8cff;
  --chart-2: #60a5fa;
  --chart-3: #38bdf8;
  --chart-4: #2563eb;
  --chart-5: #1d4ed8;

  --sidebar: #1a1f30;
  --sidebar-foreground: #f8fafc;

  --sidebar-primary: #2d8cff;
  --sidebar-primary-foreground: #ffffff;

  --sidebar-accent: #262c40;
  --sidebar-accent-foreground: #f8fafc;

  --sidebar-border: #31384d;
  --sidebar-ring: #2d8cff;

  --radius: 1rem;

  --shadow-2xs: 0 1px 2px rgb(0 0 0 / 0.15);
  --shadow-xs: 0 2px 4px rgb(0 0 0 / 0.18);
  --shadow-sm: 0 4px 12px rgb(0 0 0 / 0.22);
  --shadow: 0 8px 18px rgb(0 0 0 / 0.28);
  --shadow-md: 0 12px 25px rgb(0 0 0 / 0.32);
  --shadow-lg: 0 16px 35px rgb(0 0 0 / 0.38);
  --shadow-xl: 0 20px 45px rgb(0 0 0 / 0.45);
  --shadow-2xl: 0 30px 60px rgb(0 0 0 / 0.55);
}

@theme inline {
  --color-background: var(--background);
  --color-foreground: var(--foreground);

  --color-card: var(--card);
  --color-card-foreground: var(--card-foreground);

  --color-popover: var(--popover);
  --color-popover-foreground: var(--popover-foreground);

  --color-primary: var(--primary);
  --color-primary-foreground: var(--primary-foreground);

  --color-secondary: var(--secondary);
  --color-secondary-foreground: var(--secondary-foreground);

  --color-muted: var(--muted);
  --color-muted-foreground: var(--muted-foreground);

  --color-accent: var(--accent);
  --color-accent-foreground: var(--accent-foreground);

  --color-destructive: var(--destructive);
  --color-destructive-foreground: var(--destructive-foreground);

  --color-border: var(--border);
  --color-input: var(--input);
  --color-ring: var(--ring);

  --color-chart-1: var(--chart-1);
  --color-chart-2: var(--chart-2);
  --color-chart-3: var(--chart-3);
  --color-chart-4: var(--chart-4);
  --color-chart-5: var(--chart-5);

  --color-sidebar: var(--sidebar);
  --color-sidebar-foreground: var(--sidebar-foreground);
  --color-sidebar-primary: var(--sidebar-primary);
  --color-sidebar-primary-foreground: var(--sidebar-primary-foreground);
  --color-sidebar-accent: var(--sidebar-accent);
  --color-sidebar-accent-foreground: var(--sidebar-accent-foreground);
  --color-sidebar-border: var(--sidebar-border);
  --color-sidebar-ring: var(--sidebar-ring);

  --font-sans: var(--font-sans);
  --font-serif: var(--font-serif);
  --font-mono: var(--font-mono);

  --radius-sm: calc(var(--radius) - 4px);
  --radius-md: calc(var(--radius) - 2px);
  --radius-lg: var(--radius);
  --radius-xl: calc(var(--radius) + 4px);

  --shadow-2xs: var(--shadow-2xs);
  --shadow-xs: var(--shadow-xs);
  --shadow-sm: var(--shadow-sm);
  --shadow: var(--shadow);
  --shadow-md: var(--shadow-md);
  --shadow-lg: var(--shadow-lg);
  --shadow-xl: var(--shadow-xl);
  --shadow-2xl: var(--shadow-2xl);
}

@layer base {
  * {
    @apply border-border outline-ring/50;
  }

  html {
    scroll-behavior: smooth;
  }

  body {
    @apply bg-background text-foreground;
    font-family: var(--font-sans);
    letter-spacing: -0.01em;
  }
}