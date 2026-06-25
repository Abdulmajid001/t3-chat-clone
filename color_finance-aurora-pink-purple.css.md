@import "tailwindcss";
@import "tw-animate-css";

@custom-variant dark (&:is(.dark *));

:root {
  /* Base */
  --background: #f8f8fa;
  --foreground: #18181b;

  /* Cards */
  --card: #ffffff;
  --card-foreground: #18181b;

  /* Popover */
  --popover: #ffffff;
  --popover-foreground: #18181b;

  /* Brand */
  --primary: #7c3aed;
  --primary-foreground: #ffffff;

  /* Secondary */
  --secondary: #f3f4f6;
  --secondary-foreground: #18181b;

  /* Muted */
  --muted: #f6f7fb;
  --muted-foreground: #71717a;

  /* Accent */
  --accent: #f4f4f5;
  --accent-foreground: #18181b;

  /* Danger */
  --destructive: #ef4444;
  --destructive-foreground: #ffffff;

  /* Borders */
  --border: #ececf0;
  --input: #ececf0;
  --ring: #8b5cf6;

  /* Charts */
  --chart-1: #8b5cf6;
  --chart-2: #ec4899;
  --chart-3: #06b6d4;
  --chart-4: #f59e0b;
  --chart-5: #6366f1;

  /* Sidebar */
  --sidebar: #ffffff;
  --sidebar-foreground: #18181b;
  --sidebar-primary: #000000;
  --sidebar-primary-foreground: #ffffff;
  --sidebar-accent: #f5f5f7;
  --sidebar-accent-foreground: #18181b;
  --sidebar-border: #ececf0;
  --sidebar-ring: #8b5cf6;

  /* Radius */
  --radius: 1rem;

  /* Typography */
  --font-sans:
    Inter,
    ui-sans-serif,
    system-ui,
    -apple-system,
    BlinkMacSystemFont,
    "Segoe UI",
    sans-serif;

  --font-serif:
    ui-serif,
    Georgia,
    Cambria,
    "Times New Roman",
    serif;

  --font-mono:
    ui-monospace,
    SFMono-Regular,
    Menlo,
    Monaco,
    Consolas,
    monospace;

  /* Shadows */
  --shadow-2xs: 0 1px 2px rgba(15, 23, 42, 0.02);
  --shadow-xs: 0 1px 3px rgba(15, 23, 42, 0.04);
  --shadow-sm: 0 2px 8px rgba(15, 23, 42, 0.05);
  --shadow: 0 4px 12px rgba(15, 23, 42, 0.06);
  --shadow-md: 0 8px 20px rgba(15, 23, 42, 0.08);
  --shadow-lg: 0 12px 28px rgba(15, 23, 42, 0.10);
  --shadow-xl: 0 20px 40px rgba(15, 23, 42, 0.12);
  --shadow-2xl: 0 30px 60px rgba(15, 23, 42, 0.18);

  --tracking-normal: 0em;
  --spacing: 0.25rem;
}

.dark {
  --background: #09090b;
  --foreground: #fafafa;

  --card: #111113;
  --card-foreground: #fafafa;

  --popover: #111113;
  --popover-foreground: #fafafa;

  --primary: #a78bfa;
  --primary-foreground: #09090b;

  --secondary: #18181b;
  --secondary-foreground: #fafafa;

  --muted: #18181b;
  --muted-foreground: #a1a1aa;

  --accent: #27272a;
  --accent-foreground: #fafafa;

  --destructive: #dc2626;
  --destructive-foreground: #ffffff;

  --border: #27272a;
  --input: #27272a;
  --ring: #a78bfa;

  --chart-1: #a78bfa;
  --chart-2: #f472b6;
  --chart-3: #22d3ee;
  --chart-4: #fbbf24;
  --chart-5: #818cf8;

  --sidebar: #0f0f11;
  --sidebar-foreground: #fafafa;
  --sidebar-primary: #ffffff;
  --sidebar-primary-foreground: #09090b;
  --sidebar-accent: #18181b;
  --sidebar-accent-foreground: #fafafa;
  --sidebar-border: #27272a;
  --sidebar-ring: #a78bfa;
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

  --radius-sm: calc(var(--radius) - 6px);
  --radius-md: calc(var(--radius) - 3px);
  --radius-lg: var(--radius);
  --radius-xl: calc(var(--radius) + 6px);

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
    @apply bg-background text-foreground antialiased;
    font-family: var(--font-sans);
  }
}