@import "tailwindcss";
@import "tw-animate-css";

@custom-variant dark (&:is(.dark *));

:root {
  --background: #faf5fa;
  --foreground: #501854;
  --card: #faf5fa;
  --card-foreground: #501854;
  --popover: #ffffff;
  --popover-foreground: #501854;
  --primary: #a84370;
  --primary-foreground: #ffffff;
  --secondary: #f1c4e6;
  --secondary-foreground: #77347c;
  --muted: #f6e5f3;
  --muted-foreground: #834588;
  --accent: #f1c4e6;
  --accent-foreground: #77347c;
  --destructive: #ab4347;
  --destructive-foreground: #ffffff;
  --border: #efbdeb;
  --input: #e7c1dc;
  --ring: #db2777;
  --chart-1: #d926a2;
  --chart-2: #6c12b9;
  --chart-3: #274754;
  --chart-4: #e8c468;
  --chart-5: #f4a462;
  --sidebar: #f3e4f6;
  --sidebar-foreground: #ac1668;
  --sidebar-primary: #454554;
  --sidebar-primary-foreground: #faf1f7;
  --sidebar-accent: #f8f8f7;
  --sidebar-accent-foreground: #454554;
  --sidebar-border: #eceae9;
  --sidebar-ring: #db2777;
  --font-sans: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, 'Helvetica Neue', Arial, 'Noto Sans', sans-serif, 'Apple Color Emoji', 'Segoe UI Emoji', 'Segoe UI Symbol', 'Noto Color Emoji';
  --font-serif: ui-serif, Georgia, Cambria, "Times New Roman", Times, serif;
  --font-mono: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  --radius: 0.5rem;
  --shadow-x: 0;
  --shadow-y: 1px;
  --shadow-blur: 3px;
  --shadow-spread: 0px;
  --shadow-opacity: 0.1;
  --shadow-color: oklch(0 0 0);
  --shadow-2xs: 0 1px 3px 0px hsl(0 0% 0% / 0.05);
  --shadow-xs: 0 1px 3px 0px hsl(0 0% 0% / 0.05);
  --shadow-sm: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 1px 2px -1px hsl(0 0% 0% / 0.10);
  --shadow: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 1px 2px -1px hsl(0 0% 0% / 0.10);
  --shadow-md: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 2px 4px -1px hsl(0 0% 0% / 0.10);
  --shadow-lg: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 4px 6px -1px hsl(0 0% 0% / 0.10);
  --shadow-xl: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 8px 10px -1px hsl(0 0% 0% / 0.10);
  --shadow-2xl: 0 1px 3px 0px hsl(0 0% 0% / 0.25);
  --tracking-normal: 0em;
  --spacing: 0.25rem;
}

.dark {
  --background: #221d27;
  --foreground: #d2c4de;
  --card: #2c2632;
  --card-foreground: #dbc5d2;
  --popover: #100a0e;
  --popover-foreground: #f8f1f5;
  --primary: #a3004c;
  --primary-foreground: #efc0d8;
  --secondary: #362d3d;
  --secondary-foreground: #d4c7e1;
  --muted: #28222d;
  --muted-foreground: #c2b6cf;
  --accent: #463753;
  --accent-foreground: #f8f1f5;
  --destructive: #301015;
  --destructive-foreground: #ffffff;
  --border: #3b3237;
  --input: #3e343c;
  --ring: #db2777;
  --chart-1: #a84370;
  --chart-2: #934dcb;
  --chart-3: #e88c30;
  --chart-4: #af57db;
  --chart-5: #e23670;
  --sidebar: #181117;
  --sidebar-foreground: #e0cad6;
  --sidebar-primary: #1d4ed8;
  --sidebar-primary-foreground: #ffffff;
  --sidebar-accent: #261922;
  --sidebar-accent-foreground: #f4f4f5;
  --sidebar-border: #000000;
  --sidebar-ring: #db2777;
  --font-sans: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, 'Helvetica Neue', Arial, 'Noto Sans', sans-serif, 'Apple Color Emoji', 'Segoe UI Emoji', 'Segoe UI Symbol', 'Noto Color Emoji';
  --font-serif: ui-serif, Georgia, Cambria, "Times New Roman", Times, serif;
  --font-mono: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  --radius: 0.5rem;
  --shadow-x: 0;
  --shadow-y: 1px;
  --shadow-blur: 3px;
  --shadow-spread: 0px;
  --shadow-opacity: 0.1;
  --shadow-color: oklch(0 0 0);
  --shadow-2xs: 0 1px 3px 0px hsl(0 0% 0% / 0.05);
  --shadow-xs: 0 1px 3px 0px hsl(0 0% 0% / 0.05);
  --shadow-sm: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 1px 2px -1px hsl(0 0% 0% / 0.10);
  --shadow: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 1px 2px -1px hsl(0 0% 0% / 0.10);
  --shadow-md: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 2px 4px -1px hsl(0 0% 0% / 0.10);
  --shadow-lg: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 4px 6px -1px hsl(0 0% 0% / 0.10);
  --shadow-xl: 0 1px 3px 0px hsl(0 0% 0% / 0.10), 0 8px 10px -1px hsl(0 0% 0% / 0.10);
  --shadow-2xl: 0 1px 3px 0px hsl(0 0% 0% / 0.25);
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
  --font-mono: var(--font-mono);
  --font-serif: var(--font-serif);

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
  body {
    @apply bg-background text-foreground;
  }
}

/* 1------------------------------------------------------------------------ */
/* 1-------------------------------DIVIDER--------------------------------- */
/* 1------------------------------------------------------------------------ */

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

/* 2------------------------------------------------------------------------ */
/* 2-------------------------------DIVIDER--------------------------------- */
/* 2------------------------------------------------------------------------ */

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



/* 3------------------------------------------------------------------------ */
/* 3--------------------------------DIVIDER--------------------------------- */
/* 3------------------------------------------------------------------------ */


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


/* 4------------------------------------------------------------------------ */
/* 4-------------------------------DIVIDER--------------------------------- */
/* 4------------------------------------------------------------------------ */

@import "tailwindcss";
@import "tw-animate-css";

@custom-variant dark (&:is(.dark *));

:root {
  /* LIGHT MODE */

  --background: #f5f7fb;
  --foreground: #111827;

  --card: #ffffff;
  --card-foreground: #111827;

  --popover: #ffffff;
  --popover-foreground: #111827;

  --primary: #2563eb;
  --primary-foreground: #ffffff;

  --secondary: #eef2ff;
  --secondary-foreground: #1e3a8a;

  --muted: #f3f4f6;
  --muted-foreground: #6b7280;

  --accent: #dbeafe;
  --accent-foreground: #1e40af;

  --destructive: #ef4444;
  --destructive-foreground: #ffffff;

  --border: #e5e7eb;
  --input: #e5e7eb;
  --ring: #3b82f6;

  /* Charts */
  --chart-1: #2563eb;
  --chart-2: #60a5fa;
  --chart-3: #06b6d4;
  --chart-4: #8b5cf6;
  --chart-5: #14b8a6;

  /* Sidebar */
  --sidebar: #ffffff;
  --sidebar-foreground: #111827;
  --sidebar-primary: #2563eb;
  --sidebar-primary-foreground: #ffffff;
  --sidebar-accent: #f3f4f6;
  --sidebar-accent-foreground: #111827;
  --sidebar-border: #e5e7eb;
  --sidebar-ring: #3b82f6;

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
    Monaco,
    Consolas,
    monospace;

  /* Shadows */
  --shadow-2xs: 0 1px 2px rgb(15 23 42 / 0.03);
  --shadow-xs: 0 2px 4px rgb(15 23 42 / 0.04);
  --shadow-sm: 0 4px 10px rgb(15 23 42 / 0.06);
  --shadow: 0 8px 20px rgb(15 23 42 / 0.08);
  --shadow-md: 0 12px 24px rgb(15 23 42 / 0.10);
  --shadow-lg: 0 18px 36px rgb(15 23 42 / 0.12);
  --shadow-xl: 0 24px 48px rgb(15 23 42 / 0.14);
  --shadow-2xl: 0 32px 64px rgb(15 23 42 / 0.18);

  --tracking-normal: 0em;
  --spacing: 0.25rem;
}

.dark {
  /* MAIN BACKGROUND */
  --background: #0f172a;
  --foreground: #f8fafc;

  /* CARDS */
  --card: #182235;
  --card-foreground: #f8fafc;

  /* POPOVERS */
  --popover: #182235;
  --popover-foreground: #f8fafc;

  /* PRIMARY BLUE */
  --primary: #3b82f6;
  --primary-foreground: #ffffff;

  /* SECONDARY */
  --secondary: #1e293b;
  --secondary-foreground: #e2e8f0;

  /* MUTED */
  --muted: #243044;
  --muted-foreground: #94a3b8;

  /* ACCENT */
  --accent: #1d4ed8;
  --accent-foreground: #ffffff;

  /* DANGER */
  --destructive: #dc2626;
  --destructive-foreground: #ffffff;

  /* BORDERS */
  --border: #283548;
  --input: #283548;
  --ring: #3b82f6;

  /* CHARTS */
  --chart-1: #3b82f6;
  --chart-2: #60a5fa;
  --chart-3: #06b6d4;
  --chart-4: #8b5cf6;
  --chart-5: #14b8a6;

  /* SIDEBAR */
  --sidebar: #111827;
  --sidebar-foreground: #f8fafc;
  --sidebar-primary: #3b82f6;
  --sidebar-primary-foreground: #ffffff;
  --sidebar-accent: #1f2937;
  --sidebar-accent-foreground: #f8fafc;
  --sidebar-border: #283548;
  --sidebar-ring: #3b82f6;
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
    min-height: 100vh;
  }
}
