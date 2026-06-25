@import "tailwindcss";
@import "tw-animate-css";

@custom-variant dark (&:is(.dark *));

:root {
  /* Base */
  --background: #f5f9f7;
  --foreground: #102a27;

  /* Cards */
  --card: #ffffff;
  --card-foreground: #102a27;

  /* Popovers */
  --popover: #ffffff;
  --popover-foreground: #102a27;

  /* Brand */
  --primary: #16a34a;
  --primary-foreground: #ffffff;

  /* Secondary */
  --secondary: #e8f5ef;
  --secondary-foreground: #14532d;

  /* Muted */
  --muted: #f0f7f4;
  --muted-foreground: #5b7b74;

  /* Accent */
  --accent: #dcfce7;
  --accent-foreground: #166534;

  /* Status */
  --destructive: #ef4444;
  --destructive-foreground: #ffffff;

  /* Inputs */
  --border: #dcece4;
  --input: #dcece4;
  --ring: #22c55e;

  /* Charts */
  --chart-1: #22c55e;
  --chart-2: #14b8a6;
  --chart-3: #f97316;
  --chart-4: #84cc16;
  --chart-5: #0f766e;

  /* Sidebar */
  --sidebar: #083d3a;
  --sidebar-foreground: #e8fff5;
  --sidebar-primary: #22c55e;
  --sidebar-primary-foreground: #ffffff;
  --sidebar-accent: #0f4d48;
  --sidebar-accent-foreground: #ffffff;
  --sidebar-border: #14524f;
  --sidebar-ring: #22c55e;

  /* Radius */
  --radius: 1rem;

  /* Typography */
  --font-sans:
    Inter,
    ui-sans-serif,
    system-ui,
    sans-serif;

  --font-serif:
    Georgia,
    Cambria,
    serif;

  --font-mono:
    ui-monospace,
    SFMono-Regular,
    Menlo,
    monospace;

  /* Shadows */
  --shadow-2xs: 0 1px 2px rgba(8, 61, 58, 0.03);
  --shadow-xs: 0 2px 4px rgba(8, 61, 58, 0.04);
  --shadow-sm: 0 4px 8px rgba(8, 61, 58, 0.06);
  --shadow: 0 8px 16px rgba(8, 61, 58, 0.08);
  --shadow-md: 0 12px 24px rgba(8, 61, 58, 0.10);
  --shadow-lg: 0 18px 32px rgba(8, 61, 58, 0.12);
  --shadow-xl: 0 24px 48px rgba(8, 61, 58, 0.14);
  --shadow-2xl: 0 32px 64px rgba(8, 61, 58, 0.18);

  --tracking-normal: 0em;
  --spacing: 0.25rem;
}

.dark {
  --background: #071a18;
  --foreground: #ecfdf5;

  --card: #0d2623;
  --card-foreground: #ecfdf5;

  --popover: #0d2623;
  --popover-foreground: #ecfdf5;

  --primary: #22c55e;
  --primary-foreground: #052e16;

  --secondary: #11312d;
  --secondary-foreground: #dcfce7;

  --muted: #102522;
  --muted-foreground: #8ab0a5;

  --accent: #134e4a;
  --accent-foreground: #ecfdf5;

  --destructive: #dc2626;
  --destructive-foreground: #ffffff;

  --border: #1b3d39;
  --input: #1b3d39;
  --ring: #22c55e;

  --chart-1: #22c55e;
  --chart-2: #2dd4bf;
  --chart-3: #fb923c;
  --chart-4: #a3e635;
  --chart-5: #14b8a6;

  --sidebar: #041513;
  --sidebar-foreground: #ecfdf5;
  --sidebar-primary: #22c55e;
  --sidebar-primary-foreground: #ffffff;
  --sidebar-accent: #0f2624;
  --sidebar-accent-foreground: #ecfdf5;
  --sidebar-border: #163634;
  --sidebar-ring: #22c55e;
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