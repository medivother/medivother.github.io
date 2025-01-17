---
date: 2022-09-30 22:55:45
layout: post
title: Homework 1
subtitle: First homework of the course.
description: Introduction to the subject
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/v1559821647/theme2_ylcxxz.jpg
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1559821647/theme2_ylcxxz.jpg
category: intro
tags:
  - statistics
  - sapienza
author: francesco
use_math: true
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


# Definition of statistics
We will start our journey into the statistics world by analyzing two popular definitions of it. We will see that each of these definitions, written by statesmen and authors, expose primary concepts of the subject. But first, lets see an informal one:

Statistics is the science of analyzing data, either numerical data or non-numerical data. Statistics are used every day to solve problems, answer questions, and improve quality and performance.

The Heritage Dictionary defines statistics as “The mathematics of the collection, organization, and interpretation of numerical data , especially the analysis of population characteristics by inference from sampling.”

So statistics can be considered as a branch of mathematics, although some consider it to be distinct from it: the reason is that, while many scientific investigations make use of data, statistics is concerned with the use of data in the context of uncertainty. “Statistics is a body of methods for making wise decisions in the face of uncertainty” , as A.Wallis and Harry Roberts said. Uncertainty refers to epistemic situations ( context where we want to achieve knowledge ) involving unknown information, and it applies to predictions of future events and measurements; it arises in any number of fields such as insurance, physics, economics etc.. but all of them make use of statistical studies.

Anyway, there are two main branches that coexist in the statistical world: descriptive and inferential statistics are used to describe the characteristics of a set of data. Descriptive statistics is a summary statistic that qualitatively describes a collection of information: in everyday life it can be seen in charts and graphs. Inferential statistics on the other hand is the process of using data analysis to deduce properties of a probability distribution, so it is used to quantitatively describe a dataset. A more deep description of this difference can be found by the reader in [Homeowork 5](https://medivother.github.io/a-wonderful-serenity-has-taken-possession-of-my-entire-soul/).

Speaking of the devil, we will learn more about the bread and butter of this subject, which is data, in the next article.




# What is a dataset?
As we said in the previous article, the fundamental element that we take into consideration when we study statistics is data: data is a collection of discrete values that convey some information. We can collect data about litterally anything: from natural events to football games, from industrial processes to the health of pets.. every small piece of our life is made of data.

Given the fact that data are so etherogeneous, statesmen need a rigorous approach to to collect and organize them: they need to build up a dataset. Data set (or dataset) refers to any organised collection of data. The data set lists values for each of the variables and for each member of the dataset. Each value is known as a datum (Eurostat).

The process of building a dataset starts with the so called observation units: these are sets of entities from which we want to collect data, so they are our primary source; although I said that compose a “set” we cannot consider this a “dataset” yet. That’s because statistical data sets are collection of organized and specific data, and this means that it’s necessary to establish what we want to measure from this set of units. To do so, we observe the units that we picked, and assign the result of this observation to a variable. Let’s keep up with it following an example:

if we have a set of cars (data), which isn’t a dataset yet, we can measure the maximum speed of all of each of them (observation) and create a table were each car is a record reporting its name and maximum speed (variables). Now we finally have turned it into a dataset!


| Car name (variable)        | Maximum speed (variable) |
|----------------------------|--------------------------|
| Toyota Yaris (observation) |  170 km/h                |
| Fiat Panda                 | 160 km/h                 |
| Lamborghini Urus           | 305 km/h                 |
| Citroen C2                 | 150 km/h                 |
| Ferrari Roma               | 330 km/h                 |
|  Renault Clio              | 150 km/h                 |


Dataset


Having said that, we can conclude defining a distinction between what is a variable and what is an attribute: an attribute is a quality of a certain object, for example the maximum speed of a Lamborghini Urus. A variable is the logical set of attributes that can be measured. Variables can “vary” – for example, be high or low. How high, or how low, is determined by the value of the attribute

To conclude, it is also important to highlight the difference between a dataset, and another fundamental concept of statistics, populations. A population is a set of similar items such as individuals, companies, etc, on which we’d like to draw inference. For example, if we want to make inference about the proportion of HIV positive American citizens, then American citizens is our population. For obvious reasons, we cannot sample the entire population. Thus, we use a subset of our population which is called a sample. When the sampling procedure is done, the data is usually collected in a data set.

See you in the third article, to know about the applications of statistics in cryptography!

# Applications of statistics in cybersecurity
Cybersecurity is and will be a central topic of our century: banks, companies and normal people are affected every day by cyber attacks.

These attacks are reported to cost billions of dollars in lost productivity, lost data, and lost business. Detecting and modeling these attacks has only recently begun to attract the attention of statisticians. One example of real application of statistic’s techniques to protect the network is given by the Imperial College of London.

The Imperial Colledge of London uses statistics to identify intrusions and anomalous behaviour and therefore protect against cyber-attacks and fraudulent activity. Statistical techniques which have been so far been deployed include classification, data mining, streaming data analysis, cluster analysis.

More generally, some other applications of statistics in the field of cybersecurity are:

- Statistics used to predict cybersecurity risk
- Change point detection
- Graph analysis
- Penalised regression analysis
- Machine learning



# Application

You can download the application from <a href="https://drive.google.com/file/d/1yGq1WxgH9OtHRnfa25ZxU2T1X_5tG3sJ/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/205895032-6e293975-f1c0-4542-9321-11d493ea71e6.mp4" controls="controls" style="max-width: 730px;">
</video>



## Description of the app


This is just a quick and stupid app, which lets a red ball bounce around the window. The user has only the ability to stop it and let it go by pressing a button. Although I defined it as stupid, I did it for a reason: I had to learn how to handle events in C# in a .NET environment. Such events in this app are the pressure of the button , which stops the timer that makes it possible for the ball to move. The motion of an object such as the red cirle is also possible thanks to event handling: as I said, there is a timer with a certain refresh rate, that triggers a draw-ball function every 50 ms. The parameters that define the position of the ball are updated between on tick of the timer and another, and the screen is refreshed before drawing the ball in updated position. Not so stupid in the end!

# Research on app
| C#                                             | VB.NET                                                       |
|------------------------------------------------|--------------------------------------------------------------|
| case-sensitive language                        | not case-sensitive language                                  |
| "this" is used to refer to  the current object | "Me" is used to refer to the  current object                 |
| To declare a variable,  ‘declarators’ is used  | To declare a variable ‘Private,  Public, Friend, ..’ is used |
| ‘Class’ to declare a class                     | Events are automatically bound                               |
| C-based syntax                                 | Modern english syntax                                        |


