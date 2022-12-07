---
date: 2022-11-09 12:26:40
layout: post
title: Homework 6
subtitle: Inferential statistics, expected value and variance of sampling mean and sampling variance.
description: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_760/v1506079212/jekflix-capa_vfhuzh.png
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1506079212/jekflix-capa_vfhuzh.png
category: expected value
tags:
  - css
  - tips
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



# Concept of population and sampling distribution
## Population
Inferential statistics is made of two layers: one empirical. which we will call “descriptive”, and the second one which is totally theoretical and imaginary, which we will call “inferential”. The concept of population is present in both of this layers, but with some differences between the two.

Generally speaking, a population is a set of similar items or events which is of interest for some question or experiment. A statistical population can be a group of existing objects or a hypothetical and abstract group of objects conceived as a generalization from experience. The aim of statistical analysis is to produce information about some chosen population.

We can also define a population as the pool of individual entities from which a statistical sample is drawn for a study. Thus, any selection of individuals grouped by a common feature can be said to be a population. A sample may also refer to a statistically significant portion of a population, not an entire population. For this reason, a statistical analysis of a sample must report the approximate standard deviation, or standard error, of its results from the entire population as I showed in the application section of this homework. Only an analysis of an entire population would have no standard error.

So a population is a whole, it’s every member of a group and it is the opposite to a sample, which is a fraction or percentage of a group chosen to represent the population. Moreover, the statistical sample must be unbiased and accurately model the population (every unit of the population has an equal chance of selection).

Now that we defined the concept of population, and accurately separated it from the concept of sample, we can discuss about the diffrence between the descriptive and inferential layer. The first one consists of a known population, from which we extract a dataset, distributions and statistics in the end; there is also a population in the second one, but it is unknown to use. Nevertheless we want to extract also from this population datasets, distributions and statistics, but how can we do that?

We “infer” theorical probabilities from the empirical ones, on a population that we don’t know. This process is called induction. There are two main techniques to do so:

- Estimation
- Test

If we want to adopt the second one, we need to start from some hypothesis on the unknown population, then make a survey on the sample and see if it is coherent with our initial belief.

## Sampling distribution
I would define a sampling distribution as the set of probabilities in a statistic computation. The term “sampling” is related to the fact that the statistic is a function of the sampling data, obtained from a random extraction in the population. The variability inside the population is described mathematically using a random variable: n sapling observations of this variable generate n possible realizations of it, so n other random variables, which constitute a statistic sample.

So a sampling distribution is a probability distribution of a statistic obtained from a larger number of samples drawn from a specific population. The sampling distribution of a given population is the distribution of frequencies of a range of different outcomes that could possibly occur for a statistic of a population. It can be:

- continous
- discrete
- 
and this difference can be seen if we look at the function that we use to calculate the distribution:

continous -> density function
discrete -> probability function

Here we can see the relationship bewteen the two expressed mathematically:

$F(x)=Pr(x < X)=\int_{-\infty}^{x} f(x)dx$

# The expected value and variance of the sampling mean and the sampling variance
## Expected value and variance of the sampling mean
To better understand the idea of sampling mean, we can imagine $X_1,X_2,….,X_n$ as a sequence of identically distributed random variables from a distribution, $\mu$ as mean and $\sigma^2$ as variance . The sample mean is calculated as:

$\bar{X}=\frac{\sum_i X_i}{n}$

Once calculated mean of each sample we can write:

$E(\bar{X})=E(\frac{\sum_iX_i}{n})=\frac{1}{n}\sum_iE(X_i)=\frac{1}{n}nE(X)=E(X)=\mu$


So we can state that the expected value of the mean is equal to the mean.

We can use the same approach to calculate the variance:


$Var(\bar{X})=Var(\frac{\sum_i X_i}{n})=\frac{1}{n^2}Var(\sum_i X_i)=\frac{1}{n^2}nVar(X)=\frac{\sigma ^2}{n}$


So we can conclude that the variance decreases if the number of samples increases, which is undestandable because the more we make extractions from the population the more we “cover” all of its singular entities, and reduce the quadratic error.

## Expected value and variance of the sampling variance

We can make use of the same random variables that we used above to reason about expected value and variance of the sampling variance too: 

$S_2=\frac{1}{n}\sum_{i=1}^n(X_i-\bar{X})^2$  
  is the sample variance, which is used to compute how varied the sample is around the mean $\bar{X}$
  
We can now compute the values we memtioned before this way:

$E(S_2)=E(\frac{1}{n}\sum_{i=1}^n(X_i-\bar{X})^2)=\frac{n-1}{n}\sigma ^2$

$E(S_2)=E(\frac{1}{n}\sum_{i=1}^n(X_i-\bar{X})^2)=\frac{n-1}{n}\sigma ^2$


# Application

You can download the application from <a href="https://drive.google.com/file/d/1MztHI1LeFhXdkgOoKGhZQRV4WA2yScsF/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/206141013-9869ddd4-8ad5-4929-99ce-71d30f067eb2.mp4" style="max-width: 730px;">
</video>



## Description of the app
Take any population and any variable X. Draw m (large) samples of size n (as you like) and represent the following two empirical sampling distributions: Sampling Distribution of the Mean and Sampling Distribution of the Variance.
Finally, for each empirical sampling distribution compute the empirical sample mean and empirical sample variance and compare with the corrisponding values in the population.
