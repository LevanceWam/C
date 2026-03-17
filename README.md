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

<hr>

<h1>Architecture of .NET Applications</h1>

<p>
  In this lesson, you learn how a .NET application is organized internally. 
  Mosh explains how your code is grouped into <strong>classes</strong> and how those classes are packaged 
  into <strong>assemblies</strong>, which are the building blocks of .NET applications.
</p>

<hr />

<h2>Classes</h2>

<p>
  A <strong>class</strong> is the fundamental building block of a C# application. 
  Every piece of logic you write lives inside a class.
</p>

<ul>
  <li>A class is a container for your code.</li>
  <li>It can contain methods, fields, properties, and other members.</li>
  <li>Every C# program has at least one class (often named <code>Program</code>).</li>
  <li>Classes help organize code into logical units.</li>
</ul>

<p>
  Example of a simple class:
</p>

<pre>
<code>
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
    }
}
</code>
</pre>

<hr />

<h2>Assemblies</h2>

<p>
  An <strong>assembly</strong> is a compiled unit of your application. 
  When you build your project, the compiler takes all your classes and packages them into an assembly.
</p>

<ul>
  <li>An assembly is usually a <code>.exe</code> or <code>.dll</code> file.</li>
  <li>It contains compiled <strong>IL (Intermediate Language)</strong> code.</li>
  <li>It may also contain metadata describing the classes inside it.</li>
  <li>Assemblies are what the CLR loads and executes.</li>
</ul>

<p>
  Examples:
</p>

<ul>
  <li><code>MyApp.exe</code> — an executable assembly</li>
  <li><code>MyLibrary.dll</code> — a reusable library assembly</li>
</ul>

<hr />

<h2>How Classes and Assemblies Work Together</h2>

<p>
  When you build a .NET application:
</p>

<ol>
  <li>You write code inside classes.</li>
  <li>The compiler takes all your classes and compiles them into IL.</li>
  <li>The IL and metadata are packaged into an assembly (<code>.exe</code> or <code>.dll</code>).</li>
  <li>The CLR loads the assembly and executes the IL using the JIT compiler.</li>
</ol>

<p>
  This structure allows .NET applications to be modular, reusable, and easy to maintain.
</p>

<hr />

<h2>Why This Matters</h2>

<ul>
  <li>Classes help you organize your code.</li>
  <li>Assemblies help you package and distribute your code.</li>
  <li>Large applications are made of many assemblies working together.</li>
  <li>Understanding this structure is essential before learning object‑oriented programming.</li>
</ul>

<hr />

<p>
  This lesson sets the foundation for understanding how .NET applications are built, organized, and executed.
</p>
