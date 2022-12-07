---
date: 2022-11-15 12:26:40
layout: post
title: Homework 7
subtitle: Lebesgue-Stieltjes integration.
description: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/v1559822138/theme9_v273a9.jpg
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1559822138/theme9_v273a9.jpg
category: life
tags:
  - books
  - read
author: mranderson
paginate: true
---

<script type="text/javascript" id="MathJax-script" async
  src="https://cdn.jsdelivr.net/npm/mathjax@3/es5/tex-mml-chtml.js">
</script>
<script>
  MathJax = {
    tex: {
      inlineMath: [['$', '$']]
    }
  };
</script>

# Lebesgue-Stieltjes integration
In order to define the Lebesgue-Stieltjes integration, we first need to define the Lebesgue integration, of which the Lebesgue-Stieltjes is a generalization. To do that, we cane start from a generic definition of integral, which is Riemann's.

### Riemann integrals
In mathematics, the integral of a non-negative function of a single variable can be regarded, in the simplest case, as the area between the graph of that function and the x-axis. This definition led to the mathematical formulation of the Riemann integrals, where a certain portion of the domain of a function is divided in to intervals, and we approximate the area under the function as the sum of the areas of the rectangles built on those intervals, whose heights are given by the graph of the function in those intervals. Reducing the length of the intervals into infinitesimals dx, we obtain the area under the function without approximation.

![Somme-superiori](https://user-images.githubusercontent.com/99642347/206152911-370f43e3-c12a-46d2-a775-b66a19ae2ee6.png)


Although this is an extremely clear and powerful solution, it doesn't work for every function: an example of a function that cannot be integrated under the Riemann definition is the Dirichlet function, defined as:

![diriclet1](https://user-images.githubusercontent.com/99642347/206152619-487d8ee4-7324-4ea4-aa10-142b3e764419.svg)

![diriclet2](https://user-images.githubusercontent.com/99642347/206153204-45c57360-7cea-4333-b62a-b15fceed2452.png)

This function is nowhere continuous and so cannot be integrated under the Riemann definition. Henri Lebesgue expanded the definition of integration in order to include also more complex functions: for example, the above Dirichlet function can be integrated with the Lebesgue integrals.

## Intuition behind Lebesgue integrals 1
Let’s now examine the difference between Riemann integrals and Lebesgue integrals from an intuitive point of view.

For the Riemann integral, the domain is partitioned into intervals, and bars are constructed to meet the height of the graph. The areas of these bars are added together, and this approximates the integral, in effect by summing areas of the form f(x)dx where f(x) is the height of a rectangle and dx is its width.

For the Lebesgue integral, the range is partitioned into intervals, and so the region under the graph is partitioned into horizontal “slabs” (which may not be connected sets). The area of a small horizontal “slab” under the graph of f, of height dy, is equal to the measure of the slab’s width times $dy:μ({x\midf(x)>y})dy$.

The Lebesgue integral may then be defined by adding up the areas of these horizontal slabs.

## Formalization of Lebesgue integrals
In order to formalize the Lebesgue integration, we need to understand Lebesgue-measurable functions.

## Lebesgue measurable functions
We start with a measure space $(E,X,μ)$ where:
-  E is a set
-  X is a σ-algebra of subsets of E and
-  $\mu$ is a (non-negative) measure on E defined on the sets of X.

For example, E can be Euclidean n-space RN or some Lebesgue measurable subset of it, X is the σ-algebra of all Lebesgue measurable subsets of E, and μ is the Lebesgue measure. In the mathematical theory of probability, we confine our study to a probability measure μ, which satisfies μ(E)=1.

Lebesgue’s theory defines integrals for a class of functions called measurable functions. A real-valued function f on E is measurable if the pre-image of every interval of the form $(t,∞)$ is in X:

$\{x\mid f(x)>t\}\in X\quad \forall t\in \mathbb {R}.$

We can show that this is equivalent to requiring that the pre-image of any Borel subset of R be in X. The set of measurable functions is closed under algebraic operations, but more importantly it is closed under various kinds of point-wise sequential limits like: $lim sup_{k∈N}f_k$ or $lim sup_{k∈N}f_k$ (this means that the functions that we obtain from these limits are still measurable).

Note:5 a Borel set is any set in a topological space that can be formed from open sets (or, equivalently, from closed sets) through the operations of countable union, countable intersection, and relative complement. For a topological space X, the collection of all Borel sets on X forms a σ-algebra.

## Lebesque integral definition
Now we need one last thing to formalize the definition of the Lebesgue integral and that is the concept of simple functions:

A simple function s is a finite linear combination of indicator functions of measurable sets.

The indicator function of a subset A from X it’s a function

$1_{A}:X→{0,1}$

defined as

$\mathbf{1}_ A (x) = 1 \text{ if }x\in A\text{ or }0\text{ if }x\not\in A.$

So let be a1,…,an the values assumed by the simple function s and Ai={x:s(x)=ai}, then:

$s(x)=\sum_{i=1}^{n}a_i\, \mathbf{1}_ {A_i}(x)$

So finally we can define the lebesgue integral using simple function (same way we defined the Riemann integral using simple functions).

The Lebesgue integral of a simple function is defined as follows:

$\int_ {F}s\, d\mu =\sum_{i=1}^{n}a_{i}\, \mu (A_{i}\cap F),\quad F\in X.$

Let f a non-negative measurable function on E to R. The Lebesgue integral of f on the whole F with respect to the measure μ is defined as follows:

$\int_ {F}s\, d\mu =\sum_{i=1}^{n}a_{i}\, \mu (A_{i}\cap F),\quad F\in X.$

where the upper bound is evaluated considering all simple functions s such that 0≤s≤f. The value of the integral is a number in the range [0,+∞].

The set of functions such that:

$\int_ {F}s\, d\mu =\sum_{i=1}^{n}a_{i}\, \mu (A_{i}\cap F),\quad F\in X.$

is called the set of integrable functions on E according to Lebesgue with respect to the measure μ and is denoted by L1.

## Lebesgue-Stieltjes Integral

Lebesgue–Stieltjes integration generalizes both Riemann–Stieltjes and Lebesgue integration, preserving the many advantages of the former in a more general measure-theoretic framework. The Lebesgue–Stieltjes integral is the ordinary Lebesgue integral with respect to a measure known as the Lebesgue–Stieltjes measure, which may be associated to any function of bounded variation on the real line. So the process of definition of this new integral it’s exactly same of the Lebesgue’s one but starting from a different measure:

for any increasing right-continuous function g:R→R there exists a unique measure μg on (R,B(R)) satisfying the property:

$\mu_g((a,b])=g(b)−g(a)$

for every interval (a,b] with a<b.

$\mu_g$ is called the Lebesgue-Stieltjes measure belonging to g. The Lebesgue measure is simply the Lebesgue-Stieltjes measure belonging to the identity function (so we obtain μId((a,b])=l((a,b])=b−a).

The rest of the formalization is just the same as before but note that now the final form of the integral will be:

$\mu_g((a,b])=g(b)−g(a)$

since the measure that we called μ now is the measure $\mu_g$ dependent from the increasing right-continuous function g.

*Note: Given the lack of availability of specific books about the subject, which is my fault, and also given my poor experience about this topics, all the references are from wikipedia and can be found below.*

**References** \
[1] [https://en.wikipedia.org/wiki/Lebesgue_integration](https://en.wikipedia.org/wiki/Lebesgue_integration) \
[2] [https://en.wikipedia.org/wiki/Outer_measure](https://en.wikipedia.org/wiki/Outer_measure) \
[3] [https://en.wikipedia.org/wiki/Lebesgue_measure](https://en.wikipedia.org/wiki/Lebesgue_measure) \
[4] [https://it.wikipedia.org/wiki/Integrale_di_Lebesgue](https://it.wikipedia.org/wiki/Integrale_di_Lebesgue) \
[5] [https://en.wikipedia.org/wiki/Lebesgue%E2%80%93Stieltjes_integration](https://en.wikipedia.org/wiki/Lebesgue%E2%80%93Stieltjes_integration)



# Law of large numbers

### Simple intuition
The law of large numbers is a principle of probability according to which the frequencies of events with the same likelihood of occurrence even out, given enough trials or instances. As the number of experiments increases, the actual ratio of outcomes will converge on the theoretical, or expected, ratio of outcomes.

For example, if a fair coin (where heads and tails come up equally often) is tossed 1000000 times, about half of the tosses will come up heads, and half will come up tails. The heads-to-tails ratio will be extremely close to 1:1. However, if the same coin is tossed only 10 times, the ratio will likely not be 1:1, and in fact might come out far different, say 3:7 or even 0:10.

The law of large numbers is sometimes referred to as the *law of averages* and generalized, mistakenly, to situations with too few trials or instances to illustrate the law of large numbers. This error in logic is known as the *gambler’s fallacy*.

If, for example, someone tosses a fair coin and gets several heads in a row, that person might think that the next toss is more likely to come up tails than heads because they expect frequencies of outcomes to become equal. But, because each coin toss is an independent event, the true probabilities of the two outcomes are still equal for the next coin toss and any coin toss that might follow.

Nevertheless, if the coin is tossed enough times, because the probability of the either outcome is the same, the law of large numbers comes into play and the number of heads and tails will be close to equal.

### A more specific definition
To deeply understand the law of large numbers we will start from two important inequalitites that will lead us to the definition:

- Markov inequality, which states that $P(X\geq a)\leq \frac{E(X)}{a}$
- Chebyshev Inequality, which states that $P(\mid X-E(X)\mid \geq a)\leq\frac{Var(X)}{a^2}$

Let’s consider now any random variable X, let $\bar{X}$ be sample mean and we have already seen that $E(\bar{X})=\mu$ and that $Var(\bar{X})=\frac{σ^2}{n}$ in the previous article. By Chebyshev inequality:

$P(\mid \bar{X}-\mu \mid \geq a)\leq\frac{\sigma^2}{na^{2}}$

Now, since it is called Law of *large numbers*, let's consider $n->\infty$

$=> P(\mid\bar{X}-\mu \mid \geq a)\rightarrow 0$.

This is perfectly alligned with our previous intuition since this is the definition of convergence in probability:  we have that for n→∞, the sample mean $\bar{X}$ converges in probability to the expected value μ.

$\bar{X}_ n\rightarrow 0 \text{  when  } n \rightarrow +\infty$

which is called *weak law of large numbers*.

# Application

You can download the application from <a href="https://drive.google.com/file/d/14584840gyCk_emL-Cg3ohkLjiG896AMm/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/206206642-cf4c1743-cb02-4833-b285-ad0258abd2a6.mp4" controls="controls" style="max-width: 730px;">
</video>






## Description of the app
