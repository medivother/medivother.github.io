---
date: 2022-11-1 12:26:40
layout: post
title: Homework 5
subtitle: In this article we will explain the possible derivations of the mean, and also address the problem of convergence.
description: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/v1559820489/js-code_n83m7a.jpg
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1559820489/js-code_n83m7a.jpg
category: mean
tags:
  - platform
  - javascript
  - vscode
author: mranderson
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



# Arithmetic mean and its possible derivations
The word “statistics” is used in various ways: we used it to define a science, which we are studying at the moment; we usually use it when we look at graphs and charts, which we call “statistics”; lastly, this term can be used to define functions of the observed data.

The most famous and used of this family of functions is the mean, also known as average: to compute an average from a uniform set of data, we sum all of them and then we divide for the number of terms. But why do we do this? There are many possible ways to derive the mean, and we are going to analyze three of them, which are related to the properties of this function:

- Invariance
- Compensation
- Minimization of the distance


## Mean from the invariance property

The mean can be defined as the value that leaves F(d) unchanged. Let’s prove it:

| $\tilde{x} + \tilde{x} + ... + \tilde{x} + \tilde{x}$ = |
|-----------------------|
| $= x_1 + x_2 + ... + x_n$ |

$n\tilde{X}= {\sum x_i} = \frac{\sum x_i}{n}$

In this example our F(d) is a function that sums all of its terms, and then divides them by their number: the mean in this case is called *arithmetic mean*, and it represents a number which, if added into the set, basically leaves the sum unchanged. We can apply this reasoning also to different F(d): an example is the function which multiplies all the terms of the set. In this case the average is obtained by squaring this product of n terms by n, and the mean is called *geometric mean*. This function is deeply used in economics to, for example, get the average interest rate of a series.

## Mean from compensation property

We could also derive the mean from the compensation property: compensation happens, for example, when the sum of positive and negative deviations between random points on a straight line and a certain fixed point is zero. This concept will be more clear looking at the graph below:


![cartesiano](https://user-images.githubusercontent.com/99642347/206119077-855c8c8a-be82-4f63-9bd6-21248e53d8e3.png)


From this, we can assume that:

$\sum_{left} (c-x_i) = \sum_{right} (x_i - c)$ 
where c=0 in this case.
$\sum_{left} c – \sum_{left} x_i = \sum_{right} x_i  – \sum_{right} c => \sum_{left} c + \sum_{right} c = \sum_{right} x_i  + \sum_{left} x_i => c = \sum \frac{x_i}{n}$

## Mean from the minimization of the distance

We could also define the mean as the value which is the nearest to the data.

Our aim is to find the value c so that it is the closest to all the point. We could either do it by making a difference  and using its absolute value

$d(xi,c) = \mid x_i -c\mid$

or we could use the square

$d(x_i,c )= (x_i -c )^2$

Since we want a minimum, it is simpler to use this second method, but we need to choose the right unit of course.

$\sum_{min} (x_i -c)^2$

This is a specific case of a generic formula, which gives us all of the most used statistics:

$\sum_{min} |x_i -c|^r$
 that, for different values of r, represents these statistics.

- r=0 moda

- r=1 median

- r=2 arithmetic mean

- ecc


# Mathematical convergence and convergence in probability
There is a difference between what we call mathematical convergence and the concept of convergence in probability: to show it, let’s define these two concepts before.

## Mathematical convergence

Given $X_n$ a sequence of real numbers, $lim_{n->∞} x_n = a$ if $∀ e>0$ small there exist $n_0$ s.t. $\mid x_n -a \mid < e \ ∀ \ n > n_0$

It would be great to do the same in probability, computing convergence just by making the limit of a sequence, but it is not the case: the definition of convergence in the probabilistic world is different because we have to deal with random variables, which behave in a complete different manner in contrast to a sequence $X_n$. So what we need to do first, is to define the concept of *distance of two random variables*.

Convergence in probability is based on the following intuition: two random variables are “close to each other” if there is a high probability that their difference is very small.

### How to measure closeness

Let $X_n$ be a sequence of random variables defined on a sample space $\Omega$.

Take a random variable $X$ and a strictly positive number epsilon.

Suppose that we consider $X_n$ far from $X$ when

$\mid X_n -X \mid > e$

Then, the probability

$P(\mid X_n -X \mid > e)$
(1)

is the probability that $X_n$ is far from $X$.

### How to define convergence

If $X_n$ converges to $X$, the probability that $X_n$ and $X$ are far from each other should become smaller and smaller as n increases.

In other words, we should have:

$lim_{n->∞} P(\mid X_n-X>e \mid) = 0$.

Note that $P(\mid X_n-X>e \mid)$ is a sequence of real numbers. Therefore, the limit in equation (1) is the usual limit of a sequence of real numbers. We would like to be very restrictive on our criterion for deciding whether $X_n$ is far from $X$. As a consequence, condition (1) should be satisfied $\forall \epsilon$.

### Definition for sequences of random variables

The intuitive considerations above lead us to the following definition of convergence.

*Def* Let $X_n$ be a sequence of random variables defined on a sample space $\Omega$. We say that $X_n$ is convergent in probability to a random variable $X$ defined on $\Omega$ if and only if:

$lim_{n->∞} P(\mid X_n-X>e \mid) = 0 \ ∀ \ e>0$

The variable $X$ is called the probability limit of the sequence.



# Inferential vs Descriptive statistics
There are two main branches that coexist in the statistical world: descriptive and inferential statistics. They are used to describe the characteristics of a set of data. Descriptive statistics is a summary statistic that qualitatively describes a collection of information: in everyday life it can be seen in charts and graphs. Inferential statistics on the other hand is the process of using data analysis to deduce properties of a probability distribution, so it is used to quantitatively describe a dataset.

Let's understand this difference deeper, as we promised in [Homework1](https://medivother.github.io/let-flexbox-work-for-you-or-perish/). The first and most important difference between the two relies on the population: in descriptive statistics, we have and empirical population, so we perfectly know every piece of data about this set. This means that from this population, we can immediately derive a dataset, compute distributions and create statistics making use of relative frequencies. On the other hand inferential statistics are generated from a theoretical, unknown population: of this set we only know a subset, which is called *sample*, and from this subset we derive dataset,distributions,ecc as we did in descriptive statistics but... how can we go from an empirical world made of frequencies, to a theoretical one made of probabilities?

We make use of the process of *induction* to infer data from the known subset on the entire populaiton: this process allows us to go from an empirical level to a theoretical one by "deducing" theoretical probabilities on a population that we don't know. This can be done using two main techniques:
- estimation
- testing: we start from an hypotesis and then make a survey on the sample. Then we look if the survey is coherent with the first hypotesis.


# Application

### Resizable rectangle

You can download the application from <a href="https://drive.google.com/file/d/1uQgBtRdgEKRodQAUE6T81cdOai6Fme0d/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/206128020-4bd9b439-9aaa-41fb-aec0-18e9ad1cbc38.mp4" controls="controls" style="max-width: 730px;">
</video>



## Description of the app
This app generates a rectangle of fixed size, that can be resized by the user: if you scroll with the mouse you can zoom on it; if you press the left button you can drag it around the window; id you press the right button you can resize its height and width.


### Histograms
You can download the application from <a href="https://drive.google.com/file/d/1VXjYG7bekte8izLuCXqXP_ELWK2710Ly/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/206129674-4febe77b-58cd-4ed0-b48c-7de5ad195ee5.mp4" controls="controls" style="max-width: 730px;">
</video>



## Description of the app
The app takes in in simple distribution obtained from a binomial with probability p of success, and then plots it in resizable histograms, both orizontal and vertical.
