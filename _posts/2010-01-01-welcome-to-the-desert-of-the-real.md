---
date: 2022-11-16T23:48:05.000Z
layout: post
title: Homework 8
subtitle: 'Possible derivations of the normal distributions'
description: >-
  Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
  tempor incididunt ut labore et dolore magna aliqua.
image: >-
  assets/img/prova8.png
optimized_image: >-
  assets/img/prova8.png
category: blog
tags:
  - welcome
  - blog
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


# Possible derivation of the Normal Distribution
Abraham de Moivre, when he came up with this formula, had to assure that the points of inflection were exactly one standard deviation away from the center, and so that it was bell-shaped, as well as make sure that the area under the curve was exactly equal to one.And somehow they came up with the standard normal distribution, which is as follows:

$phi(x) = \frac{1}{\sqrt{2\pi}}e^{-\dfrac{1}{2}x^2}$
                                      
And even cooler, he found the distribution for when the mean was not 0 and the standard deviation was not 1, and came up with:

$f(x) = \frac{1}{\sigma\sqrt{2\pi}} e^{-\dfrac{(x - \mu)^2}{2\sigma^2}}$

This quote is from a a user on the web made me think a lot: it is frequent, for a student like me, to study concepts like the Normal Distribution, or the Lebsque integral or whatever formula, without completely making his mind about how the matematicians who studied it came up with that string of numbers. So let's get deep into the understanding of the possible derivation of the Normal Distribution.

## Idea explained by a user on StackExchange
I started to look information up on the web and came up with some different kinds of sources, some of which are more formal then others. To write this article I decided to start from a simple (and badly written) idea of a user named Tim on StackExchange, and then to subsequently add more mathematical formality to the derivation of the Normal Distribution. So let's jump into Tim's example.

Suppose I throw a dart into a dartboard. I aim at the centre of the board (0,0) but I'm not all that good with darts so the dart lands in a random position (X,Y) which has a joint density function $f:R^{2}→R^{+}$.

Let's make two assumptions about the way I play darts.

1. The density is rotationally invariant so the distribution of where my dart lands only depends on the distance of the dart to the centre.

2. The random variables X and Y are independent, how much I miss left and right makes no difference to the distribution of how much I miss up and down.

So by assumption one and Pythagoras I must be able to express the density
$f(x,y)=g(x^{2}+y^{2})$.
Now as the random variables X and Y are independent and identically distributed I must be able to express
$f(x,y)∝f(x,0)f(0,y)$.
Combining these assumptions we get that for every pair $(x,y)$ we have
$g(x^{2}+y^{2})∝g(x^{2})g(y^{2})$.
This means that g must be an exponential function
$g(t)=Ae^{−Bt}$.
So A will be some normalising constant. B somehow reflects the units I'm measuring in. (So if I measure the distance in cm B will be 10 times as big as if I measured in mm). B must be negative because the density should be a decreasing function of distance (I'm not that bad at darts.)

So to work out A I need to integrate $f(⋅,⋅)$ over $R^{2}$ a quick change of coordinates and
$\displaystyle \iint_{R}f(x,y)dxdy=2π\int_{0}^{\infty}tg(t)dt=2πB2.$

So we should set $A=\frac{B^{2}}{2π}$ it's convenient to choose B in terms of the standard deviation, so we set $B=\frac{1}{2σ}$ and $A=\frac{1}{2πσ^{2}}$.

So if I set $f~(x)=\frac{1}{\sqrt{2πσ}}e^{−x^{\frac{x^2}{2σ}}}$ then $f(x,y)=f~(x)f~(y)$.

So the e comes from the fact I wanted my X and Y coordinates to be independent and the π comes from the fact that I wanted rotational invariance so I'm integrating over a circle.

The interesting thing happens if I throw two darts. Suppose I throw my first dart aiming at (0,0) which lands at (X1,Y1), I aim my next dart at the first dart, so this one lands at (X2,Y2) with X2=X1+X and Y2=Y1+Y.

So the position of the second dart is the sum of the two errors. But my sum is still rotationally invariant and the variables X2 and Y2 are still independent, so (X2,Y2) satisfies my two assumptions.

That means that when I add independent normal distributions together I get another normal distribution.

It's this property that makes it so useful, because if I take the average of a very long sequence of random variables I should get something that's the same shape no matter how long my sequence is and taking a sequence twice as long is like adding the two sequences together. It's this property of the normal distribution that makes it so useful.

## A more formal definition
The Normal distribution came about from approximations of the binomial distribution (de Moivre), from linear regression (Gauss), and from the central limit theorem. The derivation given by Tim relates more closely to the linear regression derivation, where the amount of error is represented by a Normal distribution when errors are assumed symmetric about a mean, and to decrease away from the mean.

**Theorem**: Two identically distributed independent random variables follow a distribution, called the normal distribution, given that their probability density functions (PDFs) are known to be continuous and differentiable, symmetric about a mean, and decrease towards zero away from the mean.

**Proof**: Let X and Y be identically distributed independent random variables with continuous and differentiable PDFs. It is assumed that the PDFs are even functions, for example $f_{X}(x)=f_{X}(−x)$, and $f_{X}(x)→0$ as $x→±∞$.

Their joint PDF, because of their independence, is $f_{XY}(x,y)=f_{X}(x)f_{Y}(y)$. Because they are identically distributed and symmetric, only the norm or magnitude of the two variables is unique - that is, x and y can be interchanged with no effect on the final probability. They are identically distributed and symmetric, figuratively related to a circle, as opposed to the unequally distributed oval. Therefore, there must exist a function g(r) such that
$f_{XY}(x,y)=g(\sqrt{x^{2}+y^{2}}).$
Which, because g is not yet determined, is equivalent to
$f_XY(x,y)=g(x^{2}+y^{2})$.

From the definition of the joint distribution,
$f_{X}(x)f_{Y}(y)=g(x^{2}+y^{2})$.
Which, for y=0, gives
$f_{X}(x)∝g(x^{2})$.
Assuming $f_{Y}(0)$ is a constant. Similar argument gives
$f_{Y}(y)∝g(y^{2})$.
These last two results are significant, because substitution shows that the product of $g(x^{2})g(y^{2})$ is proportional to the sum $g(x^{2}+y^{2})$:
$g(x^{2})g(y^{2})∝g(x^{2}+y^{2})$.
And it is known from algebra that the only function to have this property is the exponential function (and the natural logarithm).

This is to say, g(r) will be some type of exponential,
$g(r)=Ae^{Br}$.
Where A and B are constants yet to be determined. We assume, now, that wherever the expected value is, the probability of error away from this expected value will decrease. That is to say, we expect that the chance of error should be minimum near the expected value, and decrease to zero away from this value. Another way of saying this is that the mean must be the maximum of g(r), and yet another way of saying this is that g(r) must approach 0 as r→±∞. In any case, we need the argument to the exponential to be negative.
$g(r)=Ae^{−Br}$.

Now if we return to our joint PDF,
$f_{XY}(x,y)=f_{X}(x)f_{Y}(y)=g(x^{2}+y^{2})$.
Here again, we can investigate the PDF of $f_{X}(x)$ alone by setting y=0,
$f_{X}(x)∝g(x^{2})=Ae^{−Bx^{2}}$.
Note that the mean of this distribution is 0. In order to give a mean of μ, this distribution becomes
$f_{X}(x)∝Ae^{−B(x−μ)^{2}}$.

The constants are determined from the fact that the integral of the PDF $f_X(x)$ must be equal to 1 for the entire domain. That is, the cumulative distribution function (CDF) must approach 1 at the upper limit (probability cannot be >100%).
$\displaystyle \int_{0}^{\infty}f_{X}(x)dx=1$.
The integral of $e^{−Bx^{2}}$ is $\sqrt{\frac{π}{B}}$, thus
$\displaystyle \int_{0}^{\infty}e^{Bx^{2}}dx=A\sqrt{\frac{π}{B}}=1$

$A=\sqrt{\frac{B}{π}}$.

The constant B is, for convenience, substituted by $σ^{2}=\frac{1}{2B}$, so that $A=\frac{1}{2πσ^{2}}$ and
$f_{X}(x)=\sqrt{\frac{1}{2πσ^{2}}}e^{\frac{−(x−μ)^{2}}{2σ^{2}}}$.
Which is, of course, the common form of what is known as the Normal distribution. Note that the proportional symbol became an equals sign, which is necessary from the assumption that X is a random variable, and all random variables have a PDF which integrates to 1. This proves the theorem.

One will find that $σ^{2}$ is called the variation, and σ is the standard deviation. The parameters $σ^{2}$ and μ, that is, the variation and the mean, may be chosen arbitrarily, and uniquely define the distribution.


# Application

## Polar coordinates

You can download the application from <a href="https://drive.google.com/file/d/1R1Qfo3_U6NL73DyDK7vSbK3uqJHmmT2L/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/206231464-dd1d2bbd-c655-4825-a63a-12fa10cf44da.mp4" controls="controls" style="max-width: 730px;">
</video>



## Description of the app
This app generates random points using polar coordinates. The radius and the angle are sampled as uniform distributions and then graph the distribution of the points obtained inside the circle of max radius.

# Application

## Generation of distributions
You can download the application from <a href="https://drive.google.com/file/d/1Ixn8y2aKpLiKiT4hGryAFgN4q0FW8Ncq/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/206236050-467993cc-cd25-4d57-99ba-aa9a4df82675.mp4" controls="controls" style="max-width: 730px;">
</video>




## Description of the app

In this app we from a sample of points taken from a normal distribution and the we computed the distributions of the following random variables: X, $X^2$, $\frac{X}{Y^2}$, $\frac{X^2}{Y^2}$ , $\frac{X}{Y}$.
