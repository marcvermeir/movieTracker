package com.mme.movietracker.api;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class Application {

	public static void main(String[] args) {
		SpringApplication.run(Application.class, args);
	}

}

//TODO: add some startup code which creates some initial data in the db

/* //TODO: >>>

		import com.zetcode.model.User;
		import com.zetcode.repository.UserRepository;
		import org.slf4j.Logger;
		import org.slf4j.LoggerFactory;
		import org.springframework.beans.factory.annotation.Autowired;
		import org.springframework.boot.CommandLineRunner;
		import org.springframework.stereotype.Component;

		import javax.transaction.Transactional;

@Component
public class MyRunner implements CommandLineRunner {

	private static final Logger logger = LoggerFactory.getLogger(MyRunner.class);

	@Autowired
	private UserRepository userRepository;

	@Override
	@Transactional
	public void run(String... args) throws Exception {

		logger.info("initializing users");

		var u1 = new User("Paul", "Smith", "paul.smith@gmail.com");
		userRepository.save(u1);

		var u2 = new User("Robert", "Black", "rb34@gmail.com");
		userRepository.save(u2);

		var u3 = new User("John", "Doe", "jdoe@gmail.com");
		userRepository.save(u3);
	}
}
*/