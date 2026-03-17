# The Ultimate C# Series 
<h2>C# vs .NET</h2>
<li>C# is a programming language</li>
<li>.NET is a framework for building applications on Windows</li>
<br>
**Note** C# is not the only language that can ultilize .NET.
<br>

<h3>.NET</h3>
Consist of 2 components:
<li>CLR (Common Language Runtime)</li>
<li>Class Library (For building Applications)</li>
<br>

<h3>How the CLR Executes Your Code</h3>
<br>
<p>When you write C# code, it goes through a two‑stage compilation pipeline:</p>
<li>C# Compiler → IL (Intermediate Language)  
Your .cs files are compiled into IL, a CPU‑agnostic instruction set.</li>

<li>IL → Native Machine Code (via JIT)  
At runtime, the Just‑In‑Time (JIT) compiler converts IL into machine code optimized for the current operating system and hardware.</li>

<p>This design allows .NET languages to be platform‑independent at compile time and optimized at runtime.</p>
<br>

<h2>Core Responsibilities of the CLR</h2>

<ul>
  <li>
    <strong>Memory Management</strong> — Automatic allocation and cleanup through the Garbage Collector, 
    reducing memory leaks and manual memory handling.
  </li>
  <li>
    <strong>Type Safety</strong> — Ensures variables and objects are used correctly, preventing invalid operations.
  </li>
  <li>
    <strong>Exception Handling</strong> — Provides a unified, structured system for detecting and managing runtime errors.
  </li>
  <li>
    <strong>Security Enforcement</strong> — Verifies code safety and enforces permissions to protect the system.
  </li>
  <li>
    <strong>Thread Management</strong> — Handles thread scheduling and synchronization for efficient multithreading.
  </li>
  <li>
    <strong>Code Verification</strong> — Ensures IL code meets safety and correctness rules before execution.
  </li>
</ul>

<hr />

<h2>Why the CLR Matters</h2>

<ul>
  <li>It abstracts away low‑level system details so developers can focus on application logic.</li>
  <li>It ensures consistent behavior across all .NET languages (C#, VB.NET, F#, etc.).</li>
  <li>It improves performance through JIT optimizations and efficient memory handling.</li>
  <li>It provides a unified runtime environment across different platforms and architectures.</li>
</ul>

<hr />

<h2>How the CLR Fits Into the .NET Ecosystem</h2>

<p>
  <strong>C#</strong> is the language you write.<br />
  <strong>.NET</strong> is the framework/platform that provides libraries and tools.<br />
  <strong>CLR</strong> is the runtime engine that executes your compiled code.
</p>

<p>
  Together, they form the full execution pipeline for building and running .NET applications.
</p>